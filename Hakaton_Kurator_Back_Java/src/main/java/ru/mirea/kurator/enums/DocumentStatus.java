package ru.mirea.kurator.enums;

public enum DocumentStatus {

    DELETED,
    SOME_OTHER_STATUS,
    IDK;

    public boolean equals(String str_status) {
        return this.toString().equals(str_status.toUpperCase());
    }

}
