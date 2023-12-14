package ru.mirea.kurator.response;

import lombok.Data;
import java.util.List;

@Data
public class SlaveByMasterIDWithRoleResponse{

    private long id;
    private String role;
    private List<Long> slaves;

}
