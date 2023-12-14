package ru.mirea.kurator.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.mirea.kurator.entity.ForumSectionEntity;

import java.util.List;
import java.util.Optional;

@Repository
public interface ForumSectionRepository extends JpaRepository<ForumSectionEntity, Long> {

    Optional<ForumSectionEntity> findById(Long id);
    Optional<ForumSectionEntity> findByForumid(Long forumid);
    Optional<List<ForumSectionEntity>> findAllByTitleContaining(String title);
    Optional<List<ForumSectionEntity>> findAllByDescriptionContaining(String description);


}
