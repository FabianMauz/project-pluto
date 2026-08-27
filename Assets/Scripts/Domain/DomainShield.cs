public class DomainShield {

    public int levelOfShieldValue { private set; get; }
    public int levelOfShieldRecharge { private set; get; }
    public int levelOfRechargeDelay { private set; get; }

    public DomainShield(int startValue, int startRecharge, int startDelay) {
        levelOfRechargeDelay = startDelay;
        levelOfShieldRecharge = startRecharge;
        levelOfShieldValue = startValue;
    }

    public float getShieldValue() {
        return (levelOfShieldValue - 1) * 20 + 10;
    }

    public float getRechargeDelay() {
        return 6 - levelOfRechargeDelay;
    }

    public float getRechargePerSecond() {
        return levelOfShieldRecharge;
    }

    public bool isValueUpgradable() {
        return levelOfShieldValue <= 4;
    }
    public bool isRechargeDelayUpgradable() {
        return levelOfRechargeDelay <= 4;
    }
    public bool isRechargeUpgradable() {
        return levelOfShieldRecharge <= 4;
    }

}
