package Proxy.Remote;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface MyRemote extends Remote {
    public String SayHello() throws RemoteException;
}
