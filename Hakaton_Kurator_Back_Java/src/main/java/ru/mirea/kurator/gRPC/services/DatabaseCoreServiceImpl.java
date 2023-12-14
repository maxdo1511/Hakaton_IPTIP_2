package ru.mirea.kurator.gRPC.services;

import com.google.common.collect.Lists;
import database.Database;
import database.DatabaseCoreGrpc;
import io.grpc.stub.StreamObserver;
import jakarta.transaction.Transactional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import ru.mirea.kurator.anatations.OnlyRoleCanModify;
import ru.mirea.kurator.entity.*;
import ru.mirea.kurator.enums.CuratorSort;
import ru.mirea.kurator.enums.UserRole;
import ru.mirea.kurator.repository.*;

import java.lang.reflect.Field;
import java.util.ArrayList;
import java.util.List;

@Service
public class DatabaseCoreServiceImpl extends DatabaseCoreGrpc.DatabaseCoreImplBase {


    private UserRepository userRepository;
    private ContactRepository contactRepository;
    private RatingRepository ratingRepository;
    private GroupRepository groupRepository;
    private KuratorTeacherRepository kuratorTeacherRepository;
    private MaterialRepository materialRepository;

    @Autowired
    public void setUserRepository(UserRepository userRepository) {
        this.userRepository = userRepository;
    }

    @Autowired
    public void setContactRepository(ContactRepository contactRepository) {
        this.contactRepository = contactRepository;
    }

    @Autowired
    public void setRatingRepository(RatingRepository ratingRepository) {
        this.ratingRepository = ratingRepository;
    }

    @Autowired
    public void setGroupRepository(GroupRepository groupRepository) {
        this.groupRepository = groupRepository;
    }

    @Autowired
    public void setKuratorTeacherRepository(KuratorTeacherRepository kuratorTeacherRepository) {
        this.kuratorTeacherRepository = kuratorTeacherRepository;
    }

    @Autowired
    public void setMaterialRepository(MaterialRepository materialRepository) {
        this.materialRepository = materialRepository;
    }

    @Override
    public void getAllUsers(Database.GetAllUsersRequest request, StreamObserver<Database.GetAllUsersResponse> responseObserver) {

        List<Database.User> users = new ArrayList<>();
        List<UserEntity> userEntities = userRepository.findAll();
        for (UserEntity userEntity : userEntities) {
            ContactEntity contactEntity = contactRepository.findContactEntityByUserid(userEntity.getId()).orElseThrow();
            Database.User user = Database.User.newBuilder()
                    .setEmail(contactEntity.getEmail())
                    .setRole(userEntity.getRole())
                    .setToken(userEntity.getToken() == null ? "null" : userEntity.getToken())
                    .build();
            users.add(user);
        }

        Database.GetAllUsersResponse response = Database.GetAllUsersResponse.
                newBuilder().
                addAllUsers(users).
                build();

        responseObserver.onNext(response);

        responseObserver.onCompleted();
    }

    @Override
    public void getCurator(Database.GetCuratorRequest request, StreamObserver<Database.GetCuratorResponse> responseObserver) {

        ContactEntity contactEntity = contactRepository.findContactEntityByEmail(request.getEmail()).orElseThrow();
        UserEntity userEntity = userRepository.findById(contactEntity.getUserid()).orElseThrow();

        Database.GetCuratorResponse response = Database.GetCuratorResponse.newBuilder()
                        .setCurator(getCuratorByUserEntity(userEntity))
                                .build();

        responseObserver.onNext(response);

        responseObserver.onCompleted();
    }

    @Override
    public void getCuratorsByRole(Database.GetCuratorsByRoleRequest request, StreamObserver<Database.GetCuratorsByRoleResponse> responseObserver) {
        List<UserEntity> userEntities = userRepository.findAllByRole(request.getRole()).orElseThrow();

        List<Database.Curator> curators = new ArrayList<>();
        for (UserEntity userEntity : userEntities) {
            curators.add(getCuratorByUserEntity(userEntity));
        }

        Database.GetCuratorsByRoleResponse response = Database.GetCuratorsByRoleResponse.newBuilder()
                .addAllCurators(curators)
                .build();

        responseObserver.onNext(response);

        responseObserver.onCompleted();
    }

    //TODO всё отрефакторить, люто неотимизированный код!!!
    @Override
    public void getSortedCurators(Database.GetSortedCuratorsRequest request, StreamObserver<Database.GetSortedCuratorsResponse> responseObserver) {
        CuratorSort curatorSort = CuratorSort.valueOrDefault(request.getSortBy());
        List<Database.Curator> curators = new ArrayList<>();
        switch (curatorSort){
            case NONE -> {
                List<UserEntity> userEntities = userRepository.findAll();
                for (UserEntity userEntity : userEntities) {
                    curators.add(getCuratorByUserEntity(userEntity));
                }
                break;
            }
            case NOGROUP -> {
                List<UserEntity> userEntities = userRepository.findAll();
                for (UserEntity userEntity : userEntities) {
                    if (UserRole.STUDENT.equals(userEntity.getRole())) {
                        GroupEntity groupEntity = groupRepository.findGroupEntityBySlaveid(userEntity.getId()).orElseThrow();
                        if (groupEntity.getGroupname() != null) {
                            continue;
                        }
                    }
                    if (UserRole.TEACHER.equals(userEntity.getRole())) {
                        List<GroupEntity> groupEntity = groupRepository.findAllByUserid(userEntity.getId()).orElseThrow();
                        if (!groupEntity.isEmpty()) {
                            continue;
                        }
                    }
                    curators.add(getCuratorByUserEntity(userEntity));
                }
                break;
            }
            case STUDENTONLY -> {
                List<UserEntity> userEntities = userRepository.findAllByRole(UserRole.STUDENT.toString().toLowerCase()).orElseThrow();
                for (UserEntity userEntity : userEntities) {
                    curators.add(getCuratorByUserEntity(userEntity));
                }
                break;
            }
            case TEACHERONLY -> {
                List<UserEntity> userEntities = userRepository.findAllByRole(UserRole.TEACHER.toString().toLowerCase()).orElseThrow();
                for (UserEntity userEntity : userEntities) {
                    curators.add(getCuratorByUserEntity(userEntity));
                }
                break;
            }
            case RATINGINCR -> {
                List<RatingEntity> ratingEntities = ratingRepository.getAllByOrderByFactor().orElseThrow();
                for (RatingEntity ratingEntity : ratingEntities) {
                    UserEntity userEntity = userRepository.findById(ratingEntity.getUserid()).orElseThrow();
                    curators.add(getCuratorByUserEntity(userEntity));
                }
                break;
            }
            case RATINGDECR -> {
                List<RatingEntity> ratingEntities = ratingRepository.getAllByOrderByFactorDesc().orElseThrow();
                for (RatingEntity ratingEntity : ratingEntities) {
                    UserEntity userEntity = userRepository.findById(ratingEntity.getUserid()).orElseThrow();
                    curators.add(getCuratorByUserEntity(userEntity));
                }
                break;
            }
        }
        Database.GetSortedCuratorsResponse response = Database.GetSortedCuratorsResponse.newBuilder()
                .addAllCurators(curators)
                .build();

        responseObserver.onNext(response);

        responseObserver.onCompleted();
    }

    @Override
    public void addCurator(Database.AddCuratorRequest request, StreamObserver<Database.AddCuratorResponse> responseObserver) {
        String email = request.getEmail();
        String role = request.getRole();

        UserEntity userEntity = new UserEntity();
        userEntity.setRole(role);
        String error = "";
        boolean result = true;
        try {
            userRepository.save(userEntity);
        }catch (Exception e) {
            result = false;
            error = e.getMessage();
        }

        RatingEntity ratingEntity = new RatingEntity();
        ratingEntity.setUserid(userEntity.getId());
        ratingEntity.setEducation(0);
        ratingEntity.setSocial(0);
        ratingEntity.setDocuments(0);
        ratingEntity.setFactor(0);
        try {
            ratingRepository.save(ratingEntity);
        }catch (Exception e) {
            result = false;
            error = e.getMessage();
        }

        ContactEntity contactEntity = new ContactEntity();
        contactEntity.setEmail(email);
        contactEntity.setUserid(userEntity.getId());
        try {
            contactRepository.save(contactEntity);
        }catch (Exception e) {
            result = false;
            error = e.getMessage();
        }

        Database.AddCuratorResponse response = Database.AddCuratorResponse.newBuilder()
                .setResult(result)
                .setError(error)
                .build();

        responseObserver.onNext(response);

        responseObserver.onCompleted();
    }

    @Override
    public void addMireaToken(Database.AddMireaTokenRequest request, StreamObserver<Database.AddMireaTokenResponse> responseObserver) {
        boolean result = true;
        String error = "";
        try {
            ContactEntity contactEntity = contactRepository.findContactEntityByEmail(request.getEmail()).orElseThrow();
            UserEntity userEntity = userRepository.findById(contactEntity.getUserid()).orElseThrow();
            userEntity.setToken(request.getToken());
            userRepository.save(userEntity);
        }catch (Exception e) {
            result = false;
            error = e.getMessage();
        }

        Database.AddMireaTokenResponse response = Database.AddMireaTokenResponse.newBuilder()
                .setResult(result)
                .setError(error)
                .build();

        responseObserver.onNext(response);

        responseObserver.onCompleted();
    }

    @Override
    public void getMireaToken(Database.GetMireaTokenRequest request, StreamObserver<Database.GetMireaTokenResponse> responseObserver) {
        Database.GetMireaTokenResponse response;
        try {
            ContactEntity contactEntity = contactRepository.findContactEntityByEmail(request.getEmail()).orElseThrow();
            UserEntity userEntity = userRepository.findById(contactEntity.getUserid()).orElseThrow();
            response = Database.GetMireaTokenResponse.newBuilder()
                    .setToken(userEntity.getToken())
                    .setResult(true)
                    .build();
        }catch (Exception e) {
            response = Database.GetMireaTokenResponse.newBuilder()
                    .setToken("none")
                    .setResult(false)
                    .setError(e.getMessage())
                    .build();
        }

        responseObserver.onNext(response);

        responseObserver.onCompleted();
    }

    @Override
    @Transactional
    public void setContact(Database.SetContactRequest request, StreamObserver<Database.SetContactResponse> responseObserver) {
        String s_field = request.getField();
        String s_value = request.getValue();
        String editorEmail = request.getEditorEmail();
        String recipient = request.getRecipientEmail();

        String message = "";
        boolean result = true;

        UserEntity userEntity = userRepository.findById(
                contactRepository.findContactEntityByEmail(editorEmail).orElseThrow().getUserid()
        ).orElseThrow();
        UserRole editorRole = UserRole.valueOf(userEntity.getRole().toUpperCase());

        ContactEntity contactEntity = contactRepository.findContactEntityByEmail(recipient).orElseThrow();
        try {
            Class<ContactEntity> c = ContactEntity.class;
            Field o_field = c.getDeclaredField(s_field);
            o_field.setAccessible(true);
            for (OnlyRoleCanModify onlyRoleCanModify : o_field.getAnnotationsByType(OnlyRoleCanModify.class)) {
                if (UserRole.lessPriority(editorRole, onlyRoleCanModify.role())) {
                    throw new RuntimeException("No permission");
                }
            }
            o_field.set(contactEntity, s_value);
            contactRepository.save(contactEntity);
            message = "success";
        } catch (NoSuchFieldException | RuntimeException | IllegalAccessException e) {
            result = false;
            message = e.getMessage();
        }

        Database.SetContactResponse response = Database.SetContactResponse.newBuilder()
                .setResult(result)
                .setMessage(message)
                .build();

        responseObserver.onNext(response);

        responseObserver.onCompleted();
    }

    @Override
    public void createCuratorPair(Database.CreateCuratorPairRequest request, StreamObserver<Database.CreateCuratorPairResponse> responseObserver) {
        UserEntity teacherEntity = userRepository.findById(contactRepository.findContactEntityByEmail(request.getTeacherEmail()).orElseThrow().getUserid()).orElseThrow();
        UserEntity studentEntity = userRepository.findById(contactRepository.findContactEntityByEmail(request.getStudentEmail()).orElseThrow().getUserid()).orElseThrow();

        boolean result = true;
        String message = "";

        if (!UserRole.STUDENT.equals(studentEntity.getRole())) {
            result = false;
            message = "Slave can't be a teacher";
        }
        if (!UserRole.TEACHER.equals(teacherEntity.getRole())) {
            result = false;
            message = "Teacher can't be a slave";
        }

        if (result) {
            try {
                GroupEntity groupEntity = new GroupEntity();
                groupEntity.setGroupname(request.getGroup());
                groupEntity.setUserid(teacherEntity.getId());
                groupEntity.setSlaveid(studentEntity.getId());
                groupRepository.save(groupEntity);

                KuratorTeacherEntity kuratorTeacherEntity = new KuratorTeacherEntity();
                kuratorTeacherEntity.setUserid(teacherEntity.getId());
                kuratorTeacherEntity.setSlaveid(studentEntity.getId());
                kuratorTeacherRepository.save(kuratorTeacherEntity);

                message = "success";
            } catch (Exception e) {
                result = false;
                message = e.getMessage();
            }
        }

        Database.CreateCuratorPairResponse response = Database.CreateCuratorPairResponse.newBuilder()
                .setResult(result)
                .setMessage(message)
                .build();

        responseObserver.onNext(response);

        responseObserver.onCompleted();
    }

    @Override
    public void setCuratorRating(Database.SetCuratorRatingRequest request, StreamObserver<Database.SetCuratorRatingResponse> responseObserver) {
        String s_field = request.getField();
        double s_value = request.getValue();
        String editorEmail = request.getEditorEmail();
        String recipientEmail = request.getRecipientEmail();

        String message = "";
        boolean result = true;
        UserEntity userEntity = userRepository.findById(
                contactRepository.findContactEntityByEmail(editorEmail).orElseThrow().getUserid()
        ).orElseThrow();
        UserRole editorRole = UserRole.valueOf(userEntity.getRole().toUpperCase());
        UserEntity recipient = userRepository.findById(
                contactRepository.findContactEntityByEmail(recipientEmail).orElseThrow().getUserid()
        ).orElseThrow();

        RatingEntity ratingEntity = ratingRepository.findByUserid(recipient.getId()).orElseThrow();
        try {
            Class<RatingEntity> c = RatingEntity.class;
            Field o_field = c.getDeclaredField(s_field);
            o_field.setAccessible(true);
            for (OnlyRoleCanModify onlyRoleCanModify : o_field.getAnnotationsByType(OnlyRoleCanModify.class)) {
                if (UserRole.lessPriority(editorRole, onlyRoleCanModify.role())) {
                    throw new RuntimeException("No permission");
                }
            }
            o_field.set(ratingEntity, s_value);
            ratingRepository.save(ratingEntity);
            message = "success";
        } catch (NoSuchFieldException | RuntimeException | IllegalAccessException e) {
            result = false;
            message = e.getMessage();
        }

        Database.SetCuratorRatingResponse response = Database.SetCuratorRatingResponse.newBuilder()
                .setResult(result)
                .setMessage(message)
                .build();

        responseObserver.onNext(response);

        responseObserver.onCompleted();
    }

    @Override
    public void addMaterial(Database.AddMaterialRequest request, StreamObserver<Database.AddMaterialResponse> responseObserver) {
        String message = "";
        boolean result = true;
        try {
            MaterialEntity materialEntity = new MaterialEntity();
            materialEntity.setTitle(request.getTitle());
            materialEntity.setDate(System.currentTimeMillis());
            materialEntity.setViews(0);
            materialEntity.setLinks(request.getLinks());
            materialEntity.setFactor(0);
            materialEntity.setRatings(0);
            materialRepository.save(materialEntity);
            message = "success";
        }catch (Exception e) {
            result = false;
            message = e.getMessage();
        }

        Database.AddMaterialResponse response = Database.AddMaterialResponse.newBuilder()
                .setResult(result)
                .setMessage(message)
                .build();

        responseObserver.onNext(response);

        responseObserver.onCompleted();
    }

    @Override
    public void getMaterials(Database.GetMaterialsRequest request, StreamObserver<Database.GetMaterialsResponse> responseObserver) {

        List<MaterialEntity> materialEntities = materialRepository.findAll();
        List<Database.Material> materials = new ArrayList<>();
        for (MaterialEntity materialEntity : materialEntities) {
            Database.Material material = Database.Material.newBuilder()
                    .setDate(materialEntity.getDate())
                    .setFactor(materialEntity.getFactor())
                    .setLinks(materialEntity.getLinks())
                    .setRatings(materialEntity.getRatings())
                    .setTitle(materialEntity.getTitle())
                    .setViews(materialEntity.getViews())
                    .build();
            materials.add(material);
        }

        Database.GetMaterialsResponse response = Database.GetMaterialsResponse.newBuilder()
                .addAllMaterial(materials)
                .build();

        responseObserver.onNext(response);

        responseObserver.onCompleted();
    }

    @Override
    public void addMaterialComment(Database.AddMaterialCommentRequest request, StreamObserver<Database.AddMaterialCommentResponse> responseObserver) {

    }

    @Override
    public void setMaterial(Database.SetMaterialRequest request, StreamObserver<Database.SetMaterialResponse> responseObserver) {
        super.setMaterial(request, responseObserver);
    }

    @Override
    public void getEvents(Database.GetEventsRequest request, StreamObserver<Database.GetEventsResponse> responseObserver) {
        super.getEvents(request, responseObserver);
    }

    @Override
    public void addEventComment(Database.AddEventCommentRequest request, StreamObserver<Database.AddEventCommentResponse> responseObserver) {
        super.addEventComment(request, responseObserver);
    }

    @Override
    public void addEvent(Database.AddEventRequest request, StreamObserver<Database.AddEventResponse> responseObserver) {
        super.addEvent(request, responseObserver);
    }

    @Override
    public void setEvent(Database.SetEventRequest request, StreamObserver<Database.SetEventResponse> responseObserver) {
        super.setEvent(request, responseObserver);
    }

    @Override
    public void getAllGroupDocuments(Database.GetAllGroupDocumentsRequest request, StreamObserver<Database.GetAllGroupDocumentsResponse> responseObserver) {
        super.getAllGroupDocuments(request, responseObserver);
    }

    @Override
    public void addGroupDocument(Database.AddGroupDocumentRequest request, StreamObserver<Database.AddGroupDocumentResponse> responseObserver) {
        super.addGroupDocument(request, responseObserver);
    }

    @Override
    public void setDocument(Database.SetGroupDocumentRequest request, StreamObserver<Database.SetGroupDocumentResponse> responseObserver) {
        super.setDocument(request, responseObserver);
    }

    public Database.Curator getCuratorByUserEntity(UserEntity userEntity) {
        RatingEntity ratingEntity = ratingRepository.findByUserid(userEntity.getId()).orElseThrow();
        ContactEntity contactEntity = contactRepository.findContactEntityByUserid(userEntity.getId()).orElseThrow();
        List<GroupEntity> groupEntity = new ArrayList<>();
        if (UserRole.STUDENT.equals(userEntity.getRole())) {
            groupEntity = Lists.newArrayList(groupRepository.findGroupEntityBySlaveid(userEntity.getId()).orElseThrow());
        }
        if (UserRole.TEACHER.equals(userEntity.getRole())) {
            groupEntity = groupRepository.findAllByUserid(userEntity.getId()).orElseThrow();
        }
        List<String> groups = new ArrayList<>();
        for (GroupEntity group : groupEntity) {
            groups.add(group.getGroupname());
        }

        Database.Ratings ratings = Database.Ratings.newBuilder()
                .setEducation(ratingEntity.getEducation())
                .setSocial(ratingEntity.getSocial())
                .setDocuments(ratingEntity.getDocuments())
                .setFactor(ratingEntity.getFactor())
                .build();

        Database.Contacts contacts = Database.Contacts.newBuilder()
                .setPhone(contactEntity.getPhone() == null ? "null" : contactEntity.getPhone())
                .setTg(contactEntity.getTg() == null ? "null" : contactEntity.getTg())
                .setEmail(contactEntity.getEmail() == null ? "null" : contactEntity.getEmail())
                .setReserve(contactEntity.getReserve() == null ? "null" : contactEntity.getReserve())
                .build();

        Database.Curator curator = Database.Curator.newBuilder()
                .setRatings(ratings)
                .setContacts(contacts)
                .addAllGroups(groups)
                .build();

        return curator;
    }
}
