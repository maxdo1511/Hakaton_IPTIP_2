package ru.mirea.kurator.gRPC;

import io.grpc.ManagedChannel;
import io.grpc.ManagedChannelBuilder;
import lombok.Getter;
import lombok.Setter;
import mireac.MireaCoreGrpc;
import mireac.Mireac;

import java.util.List;

public class Client {

    @Getter
    public static Client instance;
    private static final String HOST = "localhost:63333";
    @Setter
    @Getter
    private ManagedChannel channel;

    public Client() {
        instance = this;
    }

    public List<Mireac.Group> getAllGroups() {
        try {
            MireaCoreGrpc.MireaCoreBlockingStub stub = MireaCoreGrpc.newBlockingStub(channel);
            Mireac.GetGroupsRequest request = Mireac.GetGroupsRequest.newBuilder().build();
            Mireac.GetGroupsResponse response = stub.getGroups(request);
            return response.getGroupsList();
        }catch (Exception e) {
            e.printStackTrace();
            throw new RuntimeException();
        }
    }

    public void startGRPC() {
        runClient();
    }

    public void stopGRPC() {
        channel.shutdownNow();
    }

    private void runClient() {
        new Thread(() -> {
            Client.getInstance().setChannel(
                    ManagedChannelBuilder.forTarget(HOST).
                    usePlaintext().
                    build());
            System.out.println("client start");

            while (!Client.getInstance().channel.isTerminated()) {
                try {
                    Thread.sleep(100);
                } catch (InterruptedException e) {
                    throw new RuntimeException(e);
                }
            }
            System.out.println("client stopped");

        }).start();
    }

}
