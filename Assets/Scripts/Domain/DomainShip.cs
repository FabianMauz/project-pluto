public class DomainShip {
    public DomainMainCannon mainCanon { get; private set; }
    public DomainDrive drive { get; private set; }
    public DomainShield shield { get; private set; }
    public DomainMissile missile { get; private set; }

    public DomainShip() {
        mainCanon = new DomainMainCannon(DomainMainCannon.MainCannonAmount.ONE, 1, 1);
        drive = new DomainDrive(1, 1);
        shield = new DomainShield(1, 1, 1);
        missile = new DomainMissile(1, 0, 1, 1, 1);
    }
}
