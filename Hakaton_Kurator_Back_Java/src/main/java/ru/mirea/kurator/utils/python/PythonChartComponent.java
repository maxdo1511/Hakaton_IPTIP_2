package ru.mirea.kurator.utils.python;

import org.springframework.stereotype.Component;
import ru.mirea.kurator.entity.RatingChangeEntity;
import ru.mirea.kurator.entity.RatingEntity;

import java.io.IOException;
import java.util.Date;
import java.util.List;

@Component
public class PythonChartComponent {

    private static final String PATH = "charts/%s";
    private static final String PYTHON_SCRIPT_PATH = "python/main.py";
    private static final int PRECISION = 10000;
    private static final String COLOR = "blue";

    private static final  String RUN_COMMAND = "python {python_script} --points {points}" +
            " --path {path} --name {name} --color {color} --precision {precision}";
    public void createChart(String email, List<RatingChangeEntity> data) {

        String command = RUN_COMMAND
                .replace("{name}", email)
                .replace("{color}", COLOR)
                .replace("{precision}", PRECISION+"")
                .replace("{python_script}", PYTHON_SCRIPT_PATH);

        String path = String.format(PATH, email+".png");

        StringBuilder points_sb = new StringBuilder();
        int year = new Date(data.getFirst().getDate()*1000).getYear();
        int counter = 0;
        for (RatingChangeEntity ratingChangeEntity : data ) {
            Date date = new Date(ratingChangeEntity.getDate()*1000);
            if (year != date.getYear()) {
                counter++;
                year = date.getYear();
            }
            String date_s = String.valueOf(date.getMonth() + counter*12);
            points_sb.append(date_s);
            points_sb.append("-");
            points_sb.append(ratingChangeEntity.getFactor());
            points_sb.append(" ");
        }

        command = command
                .replace("{path}", path)
                .replace("{points}", points_sb.toString());

        try {
            Process p = Runtime.getRuntime().exec(command);
        } catch (IOException err) {
            err.printStackTrace();
        }
    }



}
