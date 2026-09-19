public class AttackDroneShop {
    private DomainShip ship;
    private Shop shop;

    public AttackDroneShop(DomainShip ship, Shop shop) {
        this.ship = ship;
        this.shop = shop;
    }

    public float getCostOfAmountUpgrade() {
        return ship.attackDrone.getCostsOfAmountUpgrade() * shop.multiplier;
    }
    public float getCostOfArmorUpgrade() {
        return ship.attackDrone.getCostsOfArmorUpgrade() * shop.multiplier;
    }
    public float getCostOfDamageUpgrade() {
        return ship.attackDrone.getCostsOfDamageUpgrade() * shop.multiplier;
    }
    public float getCostOfReloadSpeedUpgrade() {
        return ship.attackDrone.getCostsOfReloadSpeedUpgrade() * shop.multiplier;
    }
    public float getCostOfRebuildTimeUpgrade() {
        return ship.attackDrone.getCostsOfRebuildTimeUpgrade() * shop.multiplier;
    }
    public float getCostOfRangeUpgrade() {
        return ship.attackDrone.getCostsOfRangeUpgrade() * shop.multiplier;
    }
    public bool isAmountUpgradeAffordable() {
        return ship.resources >= getCostOfAmountUpgrade();
    }
    public bool isArmorUpgradeAffordable() {
        return ship.resources >= getCostOfArmorUpgrade();
    }
    public bool isDamageUpgradeAffordable() {
        return ship.resources >= getCostOfDamageUpgrade();
    }
    public bool isReloadSpeedUpgradeAffordable() {
        return ship.resources >= getCostOfReloadSpeedUpgrade();
    }
    public bool isRebuildTimeUpgradeAffordable() {
        return ship.resources >= getCostOfRebuildTimeUpgrade();
    }
    public bool isRangeUpgradeAffordable() {
        return ship.resources >= getCostOfRangeUpgrade();
    }

    public void upgradeAmount() {
        if (ship.attackDrone.isAmountUpgradable() && isAmountUpgradeAffordable()) {
            ship.spentResources(getCostOfAmountUpgrade());
            shop.increaseMultiplier();
            ship.attackDrone.upgradeAmount();
        }
    }
    public void upgradeDamage() {
        if (ship.attackDrone.isDamageUpgradable() && isDamageUpgradeAffordable()) {
            ship.spentResources(getCostOfDamageUpgrade());
            shop.increaseMultiplier();
            ship.attackDrone.upgradeDamage();
        }
    }

    public void upgradeArmor() {
        if (ship.attackDrone.isArmorUpgradable() && isArmorUpgradeAffordable()) {
            ship.spentResources(getCostOfArmorUpgrade());
            shop.increaseMultiplier();
            ship.attackDrone.upgradeArmor();
        }
    }
    public void upgradeReloadSpeed() {
        if (ship.attackDrone.isReloadSpeedUpgradable() && isReloadSpeedUpgradeAffordable()) {
            ship.spentResources(getCostOfReloadSpeedUpgrade());
            shop.increaseMultiplier();
            ship.attackDrone.upgradeReloadSpeed();
        }
    }
    public void upgradeRebuildTime() {
        if (ship.attackDrone.isRebuildTimeUpgradable() && isRebuildTimeUpgradeAffordable()) {
            ship.spentResources(getCostOfRebuildTimeUpgrade());
            shop.increaseMultiplier();
            ship.attackDrone.upgradeRebuildTime();
        }
    }
    public void upgradeRange() {
        if (ship.attackDrone.isRangeUpgradable() && isRangeUpgradeAffordable()) {
            ship.spentResources(getCostOfRangeUpgrade());
            shop.increaseMultiplier();
            ship.attackDrone.upgradeRange();
        }
    }
}
