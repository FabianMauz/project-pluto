public class DomainMainCannon {
    public MainCannonAmount amount { get; private set; }
    public int levelOfDamage { get; private set; }
    public int levelOfReloadSpeed { get; private set; }
    public DomainMainCannon(MainCannonAmount startAmount, int startDamage, int startReload) {
        amount = startAmount;
        levelOfDamage = startDamage;
        levelOfReloadSpeed = startReload;
    }

    public enum MainCannonAmount {
        ONE,
        TWO,
        FOUR
    }

    public float getDamage() {
        return DomainStats.mainCannonDamage[levelOfDamage - 1];
    }

    public void upgradeDamage() {
        levelOfDamage++;
    }

    public bool isDamageUpgradable() {
        return levelOfDamage <= DomainStats.mainCannonDamage.Length - 1;
    }

    public float getReloadSpeed() {
        return DomainStats.mainCannonReloadSpeed[levelOfDamage - 1];
    }
    public bool isAmountUpgradable() {
        return amount != MainCannonAmount.FOUR;
    }

    public void upgradeReloadSpeed() {
        levelOfReloadSpeed++;
    }
    public void upgradeAmount() {
        if (amount == MainCannonAmount.ONE) {
            amount = MainCannonAmount.TWO;
        }
        if (amount == MainCannonAmount.TWO) {
            amount = MainCannonAmount.FOUR;
        }
    }

    public bool isReloadSpeedUpgradable() {
        return levelOfReloadSpeed <= DomainStats.mainCannonReloadSpeed.Length - 1;
    }

    public float getCostOfDamageUpgrade() {
        return DomainStats.mainCannonDamageCosts[levelOfDamage - 1];
    }
    public float getCostOfReloadSpeedUpgrade() {
        return DomainStats.mainCannonReloadSpeedCosts[levelOfReloadSpeed - 1];
    }

    public float getCostOfAmountUpgrade() {
        if (amount == MainCannonAmount.ONE) {
            return DomainStats.mainCannonReloadSpeedCosts[0];
        }
        else if (amount == MainCannonAmount.TWO) {
            return DomainStats.mainCannonReloadSpeedCosts[1];
        }
        else {
            return float.MaxValue;
        }
    }
}
