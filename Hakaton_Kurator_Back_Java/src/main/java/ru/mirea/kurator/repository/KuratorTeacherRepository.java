package ru.mirea.kurator.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.mirea.kurator.entity.KuratorTeacherEntity;

import java.util.List;
import java.util.Optional;

@Repository
public interface KuratorTeacherRepository extends JpaRepository<KuratorTeacherEntity, Long> {
    Optional<List<KuratorTeacherEntity>> findAllByUserid(Long id);
}