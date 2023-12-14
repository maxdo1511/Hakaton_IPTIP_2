package ru.mirea.kurator.validation;

import javax.validation.ConstraintValidator;
import javax.validation.ConstraintValidatorContext;

public class EnumValidatorImpl implements ConstraintValidator<EnumValidator, CharSequence> {

    private Enum<?>[] enumValues;

    @Override
    public void initialize(EnumValidator constraintAnnotation) {
        Class<? extends Enum<?>> enumClass = constraintAnnotation.enumClass();
        enumValues = enumClass.getEnumConstants();
    }

    @Override
    public boolean isValid(CharSequence value, ConstraintValidatorContext context) {
        if (value == null) {
            return true; // Null values will be handled by other annotations like @NotNull
        }

        for (Enum<?> enumValue : enumValues) {
            if (enumValue.name().equalsIgnoreCase(value.toString())) {
                return true;
            }
        }

        return false;
    }
}