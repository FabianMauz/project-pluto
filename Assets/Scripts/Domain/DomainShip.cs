public class DomainShip {
    public DomainMainCannon mainCanon { get; private set; }

    public DomainShip() {
        mainCanon = new DomainMainCannon();
    }
}
