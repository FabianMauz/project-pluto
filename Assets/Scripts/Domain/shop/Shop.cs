public class Shop {
    private DomainShip ship;
    public float multiplier = 1;

    private float COST_INCREASE = .1f;

    public MainCannonShop mainCannon { get; private set; }
    public ArmorShop armor { get; private set; }
    public ShieldShop shield { get; private set; }
    public DriveShop drive { get; private set; }
    public MissileShop missile { get; private set; }
    public HarvestDroneShop harvestDrone { get; private set; }
    public AttackDroneShop attackDroneDrone { get; private set; }
    public DefenceCannonShop defenceCannon { get; private set; }

    public Shop(DomainShip ship) {
        this.ship = ship;
        mainCannon = new MainCannonShop(ship, this);
        armor = new ArmorShop(ship, this);
        shield = new ShieldShop(ship, this);
        drive = new DriveShop(ship, this);
        missile = new MissileShop(ship, this);
        harvestDrone = new HarvestDroneShop(ship, this);
        attackDroneDrone = new AttackDroneShop(ship, this);
        defenceCannon = new DefenceCannonShop(ship, this);
    }

    public void increaseMultiplier() {
        multiplier += COST_INCREASE;
    }
}
