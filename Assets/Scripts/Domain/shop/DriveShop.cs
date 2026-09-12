public class DriveShop {
    private DomainShip ship;
    private Shop shop;

    public DriveShop(DomainShip ship, Shop shop) {
        this.ship = ship;
        this.shop = shop;
    }

    public float getCostOfSpeedUpgrade() {
        return ship.drive.getSpeedUpgradeCosts() * shop.multiplier;
    }
    public float getCostOfEvadeChanceUpgrade() {
        return ship.drive.getEvadeChanceUpgradeCosts() * shop.multiplier;
    }

    public bool isSpeedUpgradeAffordable() {
        return ship.resources >= getCostOfSpeedUpgrade();
    }
    public bool isEvadeChanceUpgradeAffordable() {
        return ship.resources >= getCostOfEvadeChanceUpgrade();
    }

    public void upgradeSpeed() {
        if (ship.drive.isSpeedUpgradable() && isSpeedUpgradeAffordable()) {
            ship.spentResources(getCostOfSpeedUpgrade());
            shop.increaseMultiplier();
            ship.drive.upgradeSpeed();
        }
    }

    public void upgradeEvadeChance() {
        if (ship.drive.isEvadeUpgradable() && isEvadeChanceUpgradeAffordable()) {
            ship.spentResources(getCostOfEvadeChanceUpgrade());
            shop.increaseMultiplier();
            ship.drive.upgradeEvade();
        }
    }
}
