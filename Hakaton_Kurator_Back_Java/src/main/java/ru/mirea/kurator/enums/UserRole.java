package ru.mirea.kurator.enums;

import lombok.Getter;

@Getter
public enum UserRole {

    ADMIN(2),
    TEACHER(1),
    STUDENT(0);

    private final int priority;

    UserRole(int priority) {
        this.priority = priority;
    }

    /**
     * @param userRole target role
     * @param marker target role must have the same priority or lower
     * @return result of comparison
     */
    public static boolean lessPriority(UserRole userRole, UserRole marker) {
        return userRole.getPriority() >= marker.getPriority();
    }

    public boolean equals(String str_group) {
        return this.toString().equals(str_group.toUpperCase());
    }

}
