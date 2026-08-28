public class DomainMissile {
    public int levelOfDamage;
    public int levelOfAmount;
    public int levelOfArmor;
    public int levelOfRange;
    public int levelOfReloadSpeed;

    public DomainMissile(int startDamage, int startAmount, int startArmor, int startRange, int startReloadSpeed) {
        levelOfAmount = startAmount;
        levelOfArmor = startArmor;
        levelOfDamage = startDamage;
        levelOfRange = startRange;
        levelOfReloadSpeed = startReloadSpeed;
    }

    public void upgradeReloadSpeed() {
        levelOfReloadSpeed++;
    }

    public void upgradeDamage() {
        levelOfDamage++;
    }

    public void upgradeArmor() {
        levelOfArmor++;
    }

    public void upgradeRange() {
        levelOfRange++;
    }

    public void upgradeAmount() {
        levelOfAmount++;
    }

    public bool isReloadSpeedUpgradable() {
        return levelOfReloadSpeed <= DomainStats.missileReloadSpeed.Length - 1;
    }
    public bool isDamageUpgradable() {
        return levelOfDamage <= DomainStats.missileDamage.Length - 1;
    }

    public bool isRangeUpgradable() {
        return levelOfRange <= DomainStats.missileRange.Length - 1;
    }

    public bool isArmorUpgradable() {
        return levelOfArmor <= DomainStats.missileArmor.Length - 1;
    }

    public bool isAmountUpgradable() {
        return levelOfAmount <= DomainStats.MAX_MISSILE_AMOUNT - 1;
    }

    public float getDamage() {
        return DomainStats.missileDamage[levelOfDamage - 1];
    }

    public float getRange() {
        return DomainStats.missileRange[levelOfRange - 1];
    }

    public float getReloadSpeed() {
        return DomainStats.missileReloadSpeed[levelOfReloadSpeed - 1];
    }

    public float getArmor() {
        return DomainStats.missileArmor[levelOfArmor - 1];
    }

    public float getAmount() {
        return levelOfAmount;
    }
}
