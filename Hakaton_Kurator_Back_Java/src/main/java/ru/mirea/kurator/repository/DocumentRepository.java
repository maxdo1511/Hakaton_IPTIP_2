package ru.mirea.kurator.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.mirea.kurator.entity.DocumentEntity;

import javax.print.Doc;
import java.util.List;
import java.util.Optional;

@Repository
public interface DocumentRepository extends JpaRepository<DocumentEntity, Long> {

    Optional<DocumentEntity> findById(Long id);
    Optional<List<DocumentEntity>> findAllByGroupOrderByLastupdateDesc(String group);
    Optional<List<DocumentEntity>> findAllByGroupOrderByLastupdate(String group);
    Optional<List<DocumentEntity>> findAllByTitleContainingOrderByTitle(String title);
    Optional<List<DocumentEntity>> findAllByDescriptionContainingOrderByTitle(String description);
    Optional<List<DocumentEntity>> findAllByStatusOrderByLastupdateDesc(String status);

}
