package ru.mirea.kurator.gRPC;

import io.grpc.ServerBuilder;
import lombok.Getter;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import ru.mirea.kurator.gRPC.services.DatabaseCoreServiceImpl;

import java.io.IOException;

@Component
public class Server {

    private static final int PORT = 63333;
    private DatabaseCoreServiceImpl databaseCoreServiceImpl;

    @Autowired
    public void setDatabaseCoreServiceImpl(DatabaseCoreServiceImpl databaseCoreServiceImpl) {
        this.databaseCoreServiceImpl = databaseCoreServiceImpl;
    }

    public void startGRPC() {
        start();
    }

    private void start() {
        io.grpc.Server server = ServerBuilder.forPort(PORT)
                .addService(databaseCoreServiceImpl)
                .build();
        try {
            server.start();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
}
