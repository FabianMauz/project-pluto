public class DomainShip {
    public DomainMainCannon mainCanon { get; private set; }
    public DomainDefenceWeapon defenceCanon { get; private set; }

    public DomainDrive drive { get; private set; }
    public DomainShield shield { get; private set; }
    public DomainMissile missile { get; private set; }
    public DomainMiningDrone mineDrone { get; private set; }

    public DomainAttackDrone attackDrone { get; private set; }

    public DomainArmor armor { get; private set; }

    public float resources { get; private set; } = 0;

    public DomainShip() {
        mainCanon = new DomainMainCannon(DomainMainCannon.MainCannonAmount.ONE, 1, 1);
        defenceCanon = new DomainDefenceWeapon(0, 1, 1, 1);
        attackDrone = new DomainAttackDrone(0, 1, 1, 1, 1, 1);
        missile = new DomainMissile(1, 0, 1, 1, 1);
        shield = new DomainShield(1, 1, 1);
        armor = new DomainArmor(1, 1);
        drive = new DomainDrive(1, 1);
        mineDrone = new DomainMiningDrone(1, 1, 1);
    }

    public void collectResources(float amount) {
        resources += amount;
    }

    public void spentResources(float amount) {
        resources -= amount;
    }
}
