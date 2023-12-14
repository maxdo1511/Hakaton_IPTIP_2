package ru.mirea.kurator.entity;

import jakarta.persistence.*;
import jakarta.validation.constraints.Email;
import jakarta.validation.constraints.NotEmpty;
import jakarta.validation.constraints.Pattern;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import ru.mirea.kurator.anatations.OnlyRoleCanModify;
import ru.mirea.kurator.enums.UserRole;

import javax.validation.constraints.NotNull;

@Entity
@Table(name = "contacts")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class ContactEntity {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    @NotNull
    private Long userid;
    @Pattern(regexp = "9[0-9]{9}")
    private String phone;
    @Pattern(regexp = "[A-Za-z\\d]{5,32}")
    private String tg;
    private String reserve;
    @NotNull
    @Email
    @OnlyRoleCanModify(role = UserRole.ADMIN)
    private String email;
}
