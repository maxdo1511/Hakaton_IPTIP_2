package ru.mirea.kurator.controller;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import ru.mirea.kurator.entity.KuratorTeacherEntity;
import ru.mirea.kurator.entity.UserEntity;
import ru.mirea.kurator.enums.UserRole;
import ru.mirea.kurator.repository.KuratorTeacherRepository;
import ru.mirea.kurator.repository.UserRepository;
import ru.mirea.kurator.request.SlaveByMasterIDWithRoleRequest;
import ru.mirea.kurator.response.SlaveByMasterIDWithRoleResponse;

import java.util.ArrayList;
import java.util.List;

@RestController
@RequestMapping("/api")
public class UserController {

    private UserRepository userRepository;
    private KuratorTeacherRepository kuratorTeacherRepository;

    @Autowired
    public void setUserRepository(UserRepository userRepository) {
        this.userRepository = userRepository;
    }

    @Autowired
    public void setKuratorTeacherRepository(KuratorTeacherRepository kuratorTeacherRepository) {
        this.kuratorTeacherRepository = kuratorTeacherRepository;
    }

    @GetMapping("/user/{id}")
    ResponseEntity<?> getUserByID(@PathVariable String id) throws JsonProcessingException {
        long userId = Long.parseLong(id);
        UserEntity userEntity = userRepository.findById(userId).orElseThrow();
        ObjectMapper objectMapper = new ObjectMapper();
        return ResponseEntity.ok(objectMapper.writeValueAsString(userEntity));
    }

    @GetMapping("/teacher/{id}")
    ResponseEntity<?> getSlaveByMasterID(@PathVariable String id) throws JsonProcessingException {
        long userId = Long.parseLong(id);
        List<KuratorTeacherEntity> kuratorTeacherEntities = kuratorTeacherRepository.findAllByUserid(userId).orElseThrow();
        ObjectMapper objectMapper = new ObjectMapper();
        return ResponseEntity.ok(objectMapper.writeValueAsString(kuratorTeacherEntities));
    }

    @PostMapping("/teacher")
    ResponseEntity<?> getSlaveByMasterIDWithRole(@RequestBody SlaveByMasterIDWithRoleRequest request) {

        UserEntity userEntity = userRepository.findById(request.getId()).orElseThrow();
        if (userEntity.getRole().equalsIgnoreCase(UserRole.STUDENT.toString())) {
            return ResponseEntity.status(HttpStatus.UNAUTHORIZED).body("You do not have permission to perform this action");
        }

        List<KuratorTeacherEntity> slaves = kuratorTeacherRepository.findAllByUserid(request.getId()).orElseThrow();

        List<Long> slaveIds = new ArrayList<>();
        for (KuratorTeacherEntity kuratorEntity: slaves) {

            slaveIds.add(kuratorEntity.getSlaveid());

        }

        SlaveByMasterIDWithRoleResponse response = new SlaveByMasterIDWithRoleResponse();
        response.setId(request.getId());
        response.setRole(userEntity.getRole());
        response.setSlaves(slaveIds);

        return ResponseEntity.ok(response);
    }
}
