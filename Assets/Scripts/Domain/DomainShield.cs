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
        return DomainStats.shieldValue[levelOfShieldValue - 1];
    }

    public float getRechargeDelay() {
        return DomainStats.shieldRechargeDelay[levelOfShieldValue - 1];
    }

    public float getRechargePerSecond() {
        return DomainStats.shieldRechargePerSecond[levelOfShieldValue - 1];
    }

    public void upgadeValueLevel() {
        levelOfShieldValue++;
    }

    public void upgadeDelayLevel() {
        levelOfRechargeDelay++;
    }

    public void upgradeRechargeLevel() {
        levelOfShieldRecharge++;
    }

    public bool isValueUpgradable() {
        return levelOfShieldValue <= DomainStats.shieldValue.Length - 1;
    }
    public bool isRechargeDelayUpgradable() {
        return levelOfRechargeDelay <= DomainStats.shieldRechargeDelay.Length - 1;
    }
    public bool isRechargeUpgradable() {
        return levelOfShieldRecharge <= DomainStats.shieldRechargePerSecond.Length - 1;
    }

    public float getValueUpgradeCosts() {
        return DomainStats.ShieldValueCosts[levelOfShieldValue - 1];
    }
    public float getRechargeDelayUpgradeCosts() {
        return DomainStats.shieldRechargeDelay[levelOfRechargeDelay - 1];
    }
    public float getRechargeSpeedUpgradeCosts() {
        return DomainStats.shieldRechargePerSecond[levelOfShieldRecharge - 1];
    }
}
