
public class MissileShop {
    private DomainShip ship;
    private Shop shop;

    public MissileShop(DomainShip ship, Shop shop) {
        this.ship = ship;
        this.shop = shop;
    }

    public float getCostOfDamageUpgrade() {
        return ship.missile.getDamageUpgradeCosts() * shop.multiplier;
    }
    public float getCostOfRangeUpgrade() {
        return ship.missile.getRangeUpgradeCosts() * shop.multiplier;
    }
    public float getCostOfArmorUpgrade() {
        return ship.missile.getArmorUpgsradeCosts() * shop.multiplier;
    }
    public float getCostOReloadSpeedUpgrade() {
        return ship.missile.getReloadUpgradeCosts() * shop.multiplier;
    }
    public float getCostOfAmountUpgrade() {
        return ship.missile.getAmountUpgradeCosts() * shop.multiplier;
    }

    public bool isDamageAffordable() {
        return ship.resources >= getCostOfDamageUpgrade();
    }
    public bool isRangeAffordable() {
        return ship.resources >= getCostOfRangeUpgrade();
    }
    public bool isArmorAffordable() {
        return ship.resources >= getCostOfArmorUpgrade();
    }
    public bool isReloadSpeedAffordable() {
        return ship.resources >= getCostOReloadSpeedUpgrade();
    }
    public bool isAmountAffordable() {
        return ship.resources >= getCostOfAmountUpgrade();
    }

    public void upgradeDamage() {
        if (ship.missile.isDamageUpgradable() && isDamageAffordable()) {
            ship.spentResources(getCostOfDamageUpgrade());
            shop.increaseMultiplier();
            ship.missile.upgradeDamage();
        }
    }
    public void upgradeRange() {
        if (ship.missile.isRangeUpgradable() && isRangeAffordable()) {
            ship.spentResources(getCostOfRangeUpgrade());
            shop.increaseMultiplier();
            ship.missile.upgradeRange();
        }
    }

    public void upgradeArmor() {
        if (ship.missile.isArmorUpgradable() && isArmorAffordable()) {
            ship.spentResources(getCostOfArmorUpgrade());
            shop.increaseMultiplier();
            ship.missile.upgradeArmor();
        }
    }

    public void upgradeAmount() {
        if (ship.missile.isAmountUpgradable() && isAmountAffordable()) {
            ship.spentResources(getCostOfAmountUpgrade());
            shop.increaseMultiplier();
            ship.missile.upgradeAmount();
        }
    }

    public void upgradeReloadSpeed() {
        if (ship.missile.isReloadSpeedUpgradable() && isReloadSpeedAffordable()) {
            ship.spentResources(getCostOReloadSpeedUpgrade());
            shop.increaseMultiplier();
            ship.missile.upgradeReloadSpeed();
        }
    }
}
