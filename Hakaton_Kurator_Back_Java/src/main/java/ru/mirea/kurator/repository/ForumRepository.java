package ru.mirea.kurator.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.mirea.kurator.entity.ForumEntity;

import java.util.List;
import java.util.Optional;

@Repository
public interface ForumRepository extends JpaRepository<ForumEntity, Long> {
    Optional<ForumEntity> findById(Long id);
    List<ForumEntity> findAll();
    Optional<ForumEntity> findByTitle(String title);
    Optional<List<ForumEntity>> findByThemeOrderByTitle(String theme);

}
