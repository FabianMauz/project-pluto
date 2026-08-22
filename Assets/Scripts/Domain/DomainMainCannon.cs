public class DomainMainCannon {
    public int damage { get; private set; }
    public float reloadSpeed { get; private set; }
    public MainCannonAmount amount { get; private set; }

    public DomainMainCannon() {
        damage = 10;
        reloadSpeed = .5f;
        amount = MainCannonAmount.ONE;
    }


    public enum MainCannonAmount {
        ONE,
        TWO,
        FOUR
    }
}
