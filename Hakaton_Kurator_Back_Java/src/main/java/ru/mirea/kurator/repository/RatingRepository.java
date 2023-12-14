package ru.mirea.kurator.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.mirea.kurator.entity.RatingEntity;

import java.util.List;
import java.util.Optional;

@Repository
public interface RatingRepository extends JpaRepository<RatingEntity, Long> {
    Optional<RatingEntity> findById(Long id);
    Optional<RatingEntity> findByUserid(Long userid);
    Optional<List<RatingEntity>> getAllByOrderByEducationDesc();
    Optional<List<RatingEntity>> getAllByOrderBySocialDesc();
    Optional<List<RatingEntity>> getAllByOrderByDocumentsDesc();
    Optional<List<RatingEntity>> getAllByOrderByFactorDesc();
    Optional<List<RatingEntity>> getAllByOrderByFactor();
}
