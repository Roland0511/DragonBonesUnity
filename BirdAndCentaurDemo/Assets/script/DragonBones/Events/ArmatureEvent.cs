// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using Com.Viperstudio.Events;
namespace DragonBones.Events
{
	public class ArmatureEvent :Event
	{
		/**
		 * Dispatched after a successful z order update.
		 */
		public const string Z_ORDER_UPDATED = "zOrderUpdated";
		
		public ArmatureEvent(string type) :base(type)
		{

		}
		
		/**
		 * @private
		 * @return
		 */
		override public Event clone()
		{
			return new ArmatureEvent(this.EventType);
		}
	}
}
