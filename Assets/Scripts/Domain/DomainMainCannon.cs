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

    public void upgradeReloadSpeed() {
        levelOfReloadSpeed++;
    }

    public bool isReloadSpeedUpgradable() {
        return levelOfReloadSpeed <= DomainStats.mainCannonReloadSpeed.Length - 1;
    }
}
