package ru.mirea.kurator.anatations;

import ru.mirea.kurator.enums.UserRole;

import java.lang.annotation.ElementType;
import java.lang.annotation.Retention;
import java.lang.annotation.RetentionPolicy;
import java.lang.annotation.Target;

@Retention(RetentionPolicy.RUNTIME)
@Target(ElementType.FIELD)
public @interface OnlyRoleCanModify {

    UserRole role() default UserRole.STUDENT;

}
