package ru.mirea.kurator.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.mirea.kurator.entity.GroupEntity;

import java.util.List;
import java.util.Optional;

@Repository
public interface GroupRepository extends JpaRepository<GroupEntity, Long> {

    Optional<GroupEntity> findById(Long id);
    Optional<List<GroupEntity>> findAllByUserid(Long userid);
    Optional<GroupEntity> findGroupEntityBySlaveid(Long slaveid);
    Optional<GroupEntity> findByGroupname(String group);

}
