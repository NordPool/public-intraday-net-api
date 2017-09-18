using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace NPS.ID.PublicApi.Models.Draft
{
    [Description(@"ACTI: Active
                   IACT: Expired(will never be reopened)
                   HIBE: Closed(can be reopened)")]
    public enum ContractStateEnum
    {
        [Description("Closed (can be reopened)")]
        HIBE,
        [Description("Expired (will never be reopened)")]
        IACT,
        [Description("Active")]
        ACTI
    }
    public enum ErrorTypeEnum
    {
        NPM,
        PRE_TRADE,
        MW,
        LTS,
        XBID
    }
    public enum ErrorCodeEnum
    {
        [Description("Required field not found")]
        MISSING_REQUIRED_FIELD,
        [Description("Illegal contract id.")]
        ILLEGAL_FIELD,
        [Description("A field is not within the required range")]
        FIELD_OUT_OF_RANGE,
        [Description("Illegal field format.For instance, clientOrderId is not in UUID format")]
        FIELD_FORMAT_INVALID,
        [Description("Item cannot be found within database, cache etc. For instance, an order with clientOrderId was not found")]
        ITEM_NOT_FOUND,
        [Description("Field modification is prohibited.Read - only order fields cannot be changed")]
        ACCESS_MODE_VIOLATION,
        [Description("Other types of error occurred")]
        THIRD_PARTY
    }
    public enum OrderSideEnum
    {
        BUY,
        SELL
    }
    public enum TradeStateEnum
    {
        [Description("The trade is completed.")]
        COMPLETED,
        DISPUTED,
        NOT_CANCELLED,
        [Description("The trade is cancelled.")]
        CANCELLED
    }
    public enum LegOwnershipEnum
    {
        [Description("The leg (order) is placed by current user ")]
        OWN_BUY,
        [Description("The leg (order) is placed by current user ")]
        OWN_SELL,
        [Description("The order was placed by different user from same Company")]
        COMPANY_BUY,
        [Description("The order was placed by different user from same Company")]
        COMPANY_SELL,
        [Description("the order was placed by different company than user's.")]
        OTHER
    }
    public enum OrderTypeEnum
    {
        LIMIT,
        ICEBERG,
        USER_DEFINED_BLOCK

    }
    public enum TimeInForceEnum
    {
        [Description("(Immediate and cancel): The order is executed immediately to its maximum extent. In a case of a partial execution, the remaining volume is removed from the order book.")]
        IOC,
        [Description("(Fill or Kill): The order is immediately fully executed or deleted.")]
        FOK,
        [Description("No restrictions.")]
        NON,
        [Description("(Good Till Date) The order rests in the order book until the date specified in the expireTime field.")]
        GTD,
        [Description("(Good for the trading session): The order rests in the order book until it is either executed, removed by the user or the current trading session (trading phase) of the underlying contract ends.")]
        GFS
    }
    public enum OrderStateEnum
    {
        PENDING,
        ACTI,
        HIBE,
        IACT,
        REJECTED
    }
    public enum OrderActionEnum
    {
        USER_ADDED,
        USER_HIBERNATED,
        USER_MODIFIED,
        USER_DELETED,
        SYSTEM_HIBERNATED,
        SYSTEM_MODIFIED,
        SYSTEM_DELETED,
        PARTIAL_EXECUTION,
        FULL_EXECUTION,
        ICEBERG_SLICE_ADDED
    }
    public enum ExecutionRestrictionEnum
    {
        [Description("The order must be filled completely or not at all. The order stays in the order book until it is executed or removed by the system or user. This execution restriction can be used only in combination with User Defined Block Orders.")]
        AON,
        [Description("No restrictions.")]
        NON
    }
    public enum ProductTypeEnum
    {
        P15MIN,
        P30MIN,
        P60MIN,
        BLOCK_2H,
        BLOCK_4H,
        DON,
        DB34,
        DP,
        DEP,
        DB,
        CUSTOM_BLOCK

        //P15MIN("QH", "Quarterly_Hour_Power"),
        //P30MIN("HH", "Half_Hourly_Power"),
        //P60MIN("PH", "Intraday_Power_D"),
        //BLOCK_2H("2H", ""),
        //BLOCK_4H("4H", ""),
        //DON("DON", ""),
        //DB34("DB34", ""),
        //DP("DP", "Continuous_Power_Peak"),
        //DEP("DEP", ""),
        //DB("DB", "Continuous_Power_Base"),
        //CUSTOM_BLOCK("CB", "");
    }
    public enum TendencyEnum
    {
        [Description("Last price is higher than a previous price")]
        UP,
        [Description("Last price is lower than a previous price")]
        DOWN,
        [Description("Last price is equal to a previous price")]
        EQUAL
    }
    public enum OrderModificationTypeEnum
    {
        ACTI,
        DEAC,
        MODI,
        DELE
    }
}
