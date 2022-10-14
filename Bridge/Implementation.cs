namespace Bridge
{
    //Abstraction
    public abstract class Menu
    {
        public readonly ICoupon _coupon = null!;

        public abstract int CalculatePrice();

        public Menu(ICoupon coupon)
        {
            _coupon = coupon;
        }
    }

    //RefinedAbstraction
    public class VegettarianMenu : Menu
    {
        public VegettarianMenu(ICoupon coupon): base(coupon) 
        {

        }

        public override int CalculatePrice()
        {
            return 20 - _coupon.CouponValue;
        }
    }

    //RefinedAbstraction
    public class MeatbasedMenu : Menu
    {
        public MeatbasedMenu(ICoupon coupon): base(coupon) 
        {

        }

        public override int CalculatePrice()
        {
            return 30 - _coupon.CouponValue;
        }
    }

    //Implementor
    public interface  ICoupon
    {
        int CouponValue { get; }
    }

    //ConcreteImplementation
    public class NoCoupon : ICoupon
    {
        public int CouponValue { get => 0; }
    }

    //ConcreteImplementation
    public class OneManatCoupon : ICoupon
    {
        public int CouponValue { get => 1; }
    }

    //ConcreteImplementation
    public class TwoManatCoupon : ICoupon
    {
        public int CouponValue { get => 2; }
    }
}