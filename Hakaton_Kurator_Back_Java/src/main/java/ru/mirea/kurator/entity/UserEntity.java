package ru.mirea.kurator.entity;

import com.fasterxml.jackson.databind.annotation.EnumNaming;
import jakarta.persistence.*;
import jakarta.validation.constraints.NotBlank;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import ru.mirea.kurator.enums.UserRole;
import ru.mirea.kurator.validation.EnumValidator;

import javax.validation.constraints.NotNull;
import javax.validation.constraints.Pattern;

@Entity
@Table(name = "users")
@Data
public class UserEntity {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Pattern(regexp = "^[a-z]+$") //todo: проверить, работает ли оно вообще
    @EnumValidator(enumClass = UserRole.class)
    private String role;
    private String token;

}
