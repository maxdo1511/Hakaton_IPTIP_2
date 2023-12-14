package ru.mirea.kurator.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.mirea.kurator.entity.EventEntity;

import java.math.BigInteger;
import java.util.List;
import java.util.Optional;

@Repository
public interface EventRepository extends JpaRepository<EventEntity, Long> {

    Optional<EventEntity> findById(Long id);
    Optional<List<EventEntity>> findByTitleContainingIgnoreCase(String title);
    Optional<List<EventEntity>> findByDescriptionContainingIgnoreCase(String description);
    Optional<List<EventEntity>> findByTagsContainingIgnoreCase(String tags); //TODO: Нужно реализовать кастомный метод, чтобы разделить теги по пробелам или что-то типа того.
    Optional<List<EventEntity>> findByNextdateGreaterThan(long date);
    Optional<List<EventEntity>> findByNextdateLessThan(long date);
    Optional<List<EventEntity>> findByNextdateGreaterThanAndNextdateLessThan(long starting, long ending);
    Optional<List<EventEntity>> findByLastdateGreaterThan(long date);
    Optional<List<EventEntity>> findByLastdateLessThan(long date);
    Optional<List<EventEntity>> findByLastdateGreaterThanAndLastdateLessThan(long starting, long ending);
    Optional<List<EventEntity>> getAllByOrderByNextdate(); //а надо ли?
    Optional<List<EventEntity>> getAllByOrderByNextdateDesc(); //а надо ли?
    Optional<List<EventEntity>> getAllByOrderByLastdate(); //а надо ли?
    Optional<List<EventEntity>> getAllByOrderByLastdateDesc(); //а надо ли?
    Optional<List<EventEntity>> getAllByOrderByViews();
    Optional<List<EventEntity>> getAllByOrderByViewsDesc();
    Optional<List<EventEntity>> getAllByOrderByDynamic();
    Optional<List<EventEntity>> getAllByOrderByDynamicDesc();
}
