package ru.mirea.kurator.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.mirea.kurator.entity.EventCommentEntity;
import ru.mirea.kurator.entity.EventEntity;

import java.util.List;
import java.util.Optional;

@Repository
public interface EventCommentRepository extends JpaRepository<EventCommentEntity, Long> {

    Optional<EventCommentEntity> findById(Long id);
    Optional<List<EventCommentEntity>> findAllByUserid(Long userid);
    Optional<List<EventCommentEntity>> findAllByEventid(Long eventid);
    Optional<List<EventCommentEntity>> findAllByEventidOrderByDate(Long eventid);
    Optional<List<EventCommentEntity>> findAllByEventidOrderByDateDesc(Long eventid);
    Optional<List<EventCommentEntity>> findAllByCommentContainingIgnoreCase(String comment);

}
