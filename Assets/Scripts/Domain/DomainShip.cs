using System;

public class DomainShip {
    public DomainMainCannon mainCanon { get; private set; }
    public DomainDrive drive { get; private set; }

    public DomainShip() {
        mainCanon = new DomainMainCannon();
        drive = new DomainDrive(1, 1);
    }
}
