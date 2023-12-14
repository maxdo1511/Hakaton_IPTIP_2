package ru.mirea.kurator.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.mirea.kurator.entity.ForumSectionThemeEntity;

import java.util.List;
import java.util.Optional;

@Repository
public interface ForumSectionThemeRepository extends JpaRepository<ForumSectionThemeEntity, Long> {

    Optional<ForumSectionThemeEntity> findById(Long id);
    Optional<List<ForumSectionThemeEntity>> findByTitleContainingOrderByTitleDesc(String title);
    Optional<List<ForumSectionThemeEntity>> findByDescriptionContainingOrderByTitleDesc(String description);
    Optional<List<ForumSectionThemeEntity>> findAllByLastupdate(long date);

}
