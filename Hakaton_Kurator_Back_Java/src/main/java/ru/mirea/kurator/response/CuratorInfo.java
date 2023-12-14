package ru.mirea.kurator.response;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.List;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class CuratorInfo {

    private String role;
    private List<String> groups;
    private User user;
    private Rating rating;

}
