package ru.mirea.kurator;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import ru.mirea.kurator.entity.UserEntity;
import ru.mirea.kurator.gRPC.Client;
import ru.mirea.kurator.gRPC.Server;
import ru.mirea.kurator.gRPC.services.DatabaseCoreServiceImpl;
import ru.mirea.kurator.repository.UserRepository;

@SpringBootApplication
public class KuratorApplication {

    public static Server server;

    @Autowired
    public void setDatabaseCoreServiceImpl(Server server) {
        this.server = server;
    }

    public static void main(String[] args) {
        SpringApplication.run(KuratorApplication.class, args);

        server.startGRPC();
        new Client();
        Client.getInstance().startGRPC();
    }
}
