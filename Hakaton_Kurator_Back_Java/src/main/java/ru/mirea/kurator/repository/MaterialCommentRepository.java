package ru.mirea.kurator.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.mirea.kurator.entity.MaterialCommentEntity;
import ru.mirea.kurator.entity.MaterialEntity;

import java.util.List;
import java.util.Optional;

@Repository
public interface MaterialCommentRepository extends JpaRepository<MaterialCommentEntity, Long> {

    List<MaterialCommentEntity> findAllById(long id);

}
