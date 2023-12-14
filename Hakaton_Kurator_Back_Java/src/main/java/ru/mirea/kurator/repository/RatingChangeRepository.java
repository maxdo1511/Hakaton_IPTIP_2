package ru.mirea.kurator.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.mirea.kurator.entity.RatingChangeEntity;
import ru.mirea.kurator.entity.RatingEntity;

import java.util.List;
import java.util.Optional;

@Repository
public interface RatingChangeRepository extends JpaRepository<RatingChangeEntity, Long> {

    Optional<List<RatingChangeEntity>> findAllByUserid(Long id);
    Optional<List<RatingChangeEntity>> findByUserid(Long userid);
    Optional<List<RatingChangeEntity>> findByDate(long date);
    Optional<List<RatingChangeEntity>> findAllByOrderByFactor();
    Optional<List<RatingChangeEntity>> findAllByOrderByFactorDesc();

}
