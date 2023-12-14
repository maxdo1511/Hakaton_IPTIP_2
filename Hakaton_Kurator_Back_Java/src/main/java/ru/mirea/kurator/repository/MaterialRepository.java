package ru.mirea.kurator.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.mirea.kurator.entity.MaterialEntity;

import java.util.Optional;

@Repository
public interface MaterialRepository extends JpaRepository<MaterialEntity, Long> {

    Optional<MaterialEntity> findById(long id);

}
