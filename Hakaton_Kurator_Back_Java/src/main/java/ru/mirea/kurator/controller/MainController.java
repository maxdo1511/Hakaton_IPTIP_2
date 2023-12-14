package ru.mirea.kurator.controller;

import database.Database;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import ru.mirea.kurator.entity.ContactEntity;
import ru.mirea.kurator.entity.RatingEntity;
import ru.mirea.kurator.entity.UserEntity;
import ru.mirea.kurator.gRPC.services.DatabaseCoreServiceImpl;
import ru.mirea.kurator.repository.*;
import ru.mirea.kurator.response.CuratorInfo;
import ru.mirea.kurator.response.Rating;
import ru.mirea.kurator.response.User;
import ru.mirea.kurator.utils.python.PythonChartComponent;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

@RestController
@RequestMapping("/user")
public class MainController {

    private UserRepository userRepository;
    private KuratorTeacherRepository kuratorTeacherRepository;
    private ContactRepository contactRepository;
    private RatingRepository ratingRepository;
    private RatingChangeRepository ratingChangeRepository;
    private EventRepository eventRepository;
    private EventCommentRepository eventCommentRepository;
    private GroupRepository groupRepository;
    private DocumentRepository documentRepository;
    private ForumRepository forumRepository;
    private ForumSectionRepository forumSectionRepository;
    private ForumSectionThemeRepository forumSectionThemeRepository;
    private PythonChartComponent pythonChartComponent;
    private DatabaseCoreServiceImpl databaseCoreServiceImpl;

    @Autowired
    public void setUserRepository(UserRepository userRepository) {
        this.userRepository = userRepository;
    }

    @Autowired
    public void setRatingChangeRepository(RatingChangeRepository ratingChangeRepository) {
        this.ratingChangeRepository = ratingChangeRepository;
    }

    @Autowired
    public void setContactRepository(ContactRepository contactRepository) {
        this.contactRepository = contactRepository;
    }

    @Autowired
    public void setForumRepository(ForumRepository forumRepository) {this.forumRepository = forumRepository;}


    @Autowired
    public void setPythonChartComponent(PythonChartComponent pythonChartComponent) {
        this.pythonChartComponent = pythonChartComponent;
    }

    @Autowired
    public void setRatingRepository(RatingRepository ratingRepository) {
        this.ratingRepository = ratingRepository;
    }

    @GetMapping("/data/userdata/{email}")
    ResponseEntity<?> findPairs(@PathVariable String email) throws IOException {

        ContactEntity contactEntity = contactRepository.findContactEntityByEmail(email).orElseThrow();
        UserEntity userEntity = userRepository.findById(contactEntity.getUserid()).orElseThrow();
        Database.Curator curator = databaseCoreServiceImpl.getCuratorByUserEntity(userEntity);

        CuratorInfo curatorInfo = new CuratorInfo();
        User user = new User();
        Rating rating = new Rating();

        user.setFirstName("Максим");
        user.setSecondName("Дорошко");
        user.setEmail(email);
        user.setStudyGroup("ЭФБО-02-22");

        rating.setSocial(curator.getRatings().getSocial());
        rating.setEducation(curator.getRatings().getEducation());
        rating.setDocuments(curator.getRatings().getDocuments());
        rating.setFactor(curator.getRatings().getFactor());

        curatorInfo.setGroups(curator.getGroupsList());
        curatorInfo.setRole(userEntity.getRole());
        curatorInfo.setRating(rating);
        curatorInfo.setUser(user);

        return ResponseEntity.ok(curatorInfo);
    }


    @Autowired
    public void setDatabaseCoreServiceImpl(DatabaseCoreServiceImpl databaseCoreServiceImpl) {
        this.databaseCoreServiceImpl = databaseCoreServiceImpl;
    }
}
