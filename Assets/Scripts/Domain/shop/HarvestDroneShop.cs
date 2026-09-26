public class HarvestDroneShop {
    private DomainShip ship;
    private Shop shop;

    public HarvestDroneShop(DomainShip ship, Shop shop) {
        this.ship = ship;
        this.shop = shop;
    }
    public float getCostOfCapacityUpgrade() {
        return ship.mineDrone.getCapacityUpgradeCosts() * shop.multiplier;
    }
    public float getCostOfMineSpeedUpgrade() {
        return ship.mineDrone.getMineSpeedUpgradeCosts() * shop.multiplier;
    }
    public float getCostOfMoveSpeedUpgrade() {
        return ship.mineDrone.getMoveSpeedUpgradeCosts() * shop.multiplier;
    }
    public bool isCapacityUpgradeAffordable() {
        return ship.resources >= getCostOfCapacityUpgrade();
    }
    public bool isMineSpeedUpgradeAffordable() {
        return ship.resources >= getCostOfMineSpeedUpgrade();
    }
    public bool isMoveSpeedUpgradeAffordable() {
        return ship.resources >= getCostOfMoveSpeedUpgrade();
    }
    public void upgradeCapacity() {
        if (ship.mineDrone.isCapacityUpgradable() && isCapacityUpgradeAffordable()) {
            ship.spentResources(getCostOfCapacityUpgrade());
            shop.increaseMultiplier();
            ship.mineDrone.upgradeCapacity();
        }
    }
    public void upgradeMineSpeed() {
        if (ship.mineDrone.isMineSpeedUpgradable() && isMineSpeedUpgradeAffordable()) {
            ship.spentResources(getCostOfMineSpeedUpgrade());
            shop.increaseMultiplier();
            ship.mineDrone.upgradeMineSpeed();
        }
    }
    public void upgradeMoveSpeed() {
        if (ship.mineDrone.isMoveSpeedUpgradable() && isMoveSpeedUpgradeAffordable()) {
            ship.spentResources(getCostOfMoveSpeedUpgrade());
            shop.increaseMultiplier();
            ship.mineDrone.upgradeMoveSpeed();
        }
    }
}
