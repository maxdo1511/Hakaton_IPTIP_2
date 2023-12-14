package ru.mirea.kurator.enums;

public enum CuratorSort {

    NONE,
    TEACHERONLY,
    STUDENTONLY,
    NOGROUP,
    RATINGDECR,
    RATINGINCR;

    public static CuratorSort valueOrDefault(String value) {
        try {
            return CuratorSort.valueOf(value.toUpperCase());
        }catch (IllegalArgumentException e) {
            return CuratorSort.NONE;
        }
    }

}
