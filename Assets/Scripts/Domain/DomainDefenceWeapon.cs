public class DomainDefenceWeapon {
    public int amount { get; private set; }
    public int levelOfDamage { get; private set; }
    public int levelOfRange { get; private set; }
    public int levelOfReloadSpeed { get; private set; }

    //Damage
    public void upgradeDamage() {
        levelOfDamage++;
    }

    public bool isDamageUpgradable() {
        return levelOfDamage <= DomainStats.defenceCannonDamage.Length - 1;
    }

    public float getDamage() {
        return DomainStats.defenceCannonDamage[levelOfDamage - 1];
    }
    //Range
    public void upgradeRange() {
        levelOfRange++;
    }

    public bool isRangeUpgradable() {
        return levelOfRange <= DomainStats.defenceCannonRange.Length - 1;
    }

    public float getRange() {
        return DomainStats.defenceCannonRange[levelOfRange - 1];
    }
    //ReloadSpeed
    public void upgradeReloadSpeed() {
        levelOfReloadSpeed++;
    }

    public bool isReloadSpeedUpgradable() {
        return levelOfReloadSpeed <= DomainStats.defenceCannonReloadSpeed.Length - 1;
    }

    public float getReloadSpeed() {
        return DomainStats.defenceCannonReloadSpeed[levelOfReloadSpeed - 1];
    }

    //Amount
    public void upgradeAmount() {
        amount++;
    }

    public bool isAmountUpgradable() {
        return amount < 2;
    }
}
