package ru.mirea.kurator.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.mirea.kurator.entity.ContactEntity;

import javax.swing.text.html.Option;
import java.util.List;
import java.util.Optional;

@Repository
public interface ContactRepository extends JpaRepository<ContactEntity, Long> {

    Optional<ContactEntity> findContactEntityByUserid(Long userid);
    Optional<ContactEntity> findContactEntityByPhone(String phone);
    Optional<ContactEntity> findContactEntityByTg(String tg);
    Optional<ContactEntity> findContactEntityByEmail(String email);
    Optional<ContactEntity> findContactEntityByReserve(String reserve);

}
