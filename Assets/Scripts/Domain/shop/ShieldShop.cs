public class ShieldShop {
    private DomainShip ship;
    private Shop shop;

    public ShieldShop(DomainShip ship, Shop shop) {
        this.ship = ship;
        this.shop = shop;
    }

    public float getCostOfValueUpgrade() {
        return ship.shield.getValueUpgradeCosts() * shop.multiplier;
    }
    public float getCostOfRechargeDelayUpgrade() {
        return ship.shield.getRechargeDelayUpgradeCosts() * shop.multiplier;
    }
    public float getCostOfRechargeSpeedUpgrade() {
        return ship.shield.getRechargeDelayUpgradeCosts() * shop.multiplier;
    }

    public bool isValueAffordable() {
        return ship.resources >= getCostOfValueUpgrade();
    }
    public bool isRechargeSpeedAffordable() {
        return ship.resources >= getCostOfRechargeSpeedUpgrade();
    }
    public bool RechargeDelay() {
        return ship.resources >= getCostOfRechargeDelayUpgrade();
    }

    public void upgradeValue() {
        if (ship.shield.isValueUpgradable() && isValueAffordable()) {
            ship.spentResources(getCostOfValueUpgrade());
            shop.increaseMultiplier();
            ship.shield.upgadeValueLevel();
        }
    }
    public void upgradeRechargeDelay() {
        if (ship.shield.isRechargeDelayUpgradable() && isRechargeSpeedAffordable()) {
            ship.spentResources(getCostOfRechargeDelayUpgrade());
            shop.increaseMultiplier();
            ship.shield.upgadeDelayLevel();
        }
    }
    public void upgradeRechargeSpeed() {
        if (ship.shield.isRechargeUpgradable() && isRechargeSpeedAffordable()) {
            ship.spentResources(getCostOfRechargeSpeedUpgrade());
            shop.increaseMultiplier();
            ship.shield.upgradeRechargeLevel();
        }
    }
}
