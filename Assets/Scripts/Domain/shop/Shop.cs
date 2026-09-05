public class Shop {
    private DomainShip ship;
    public float multiplier = 1;

    private float COST_INCREASE = .1f;

    public MainCannonShop mainCannon { get; private set; }
     public ArmorShop armor { get; private set; }
    public Shop(DomainShip ship) {
        this.ship = ship;
        mainCannon = new MainCannonShop(ship, this);
        armor=new ArmorShop(ship,this);
    }

    public void increaseMultiplier() {
        multiplier += COST_INCREASE;
    }
}
