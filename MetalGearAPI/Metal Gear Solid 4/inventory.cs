using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiLib;

namespace MetalGearAPI
{
	public class Inv
	{
		public class Weapon_s
		{
			private uint Pointer;

			public Weapons Slot1
			{
				get => (Weapons)new MCAPI().Extension.ReadInt16(Pointer);
				set => new MCAPI().Extension.WriteInt16(Pointer, (short)value);
			}

			public Weapons Slot2
			{


				get => (Weapons)new MCAPI().Extension.ReadInt16(Pointer + 2);
				set => new MCAPI().Extension.WriteInt16(Pointer + 2, (short)value);

			}

			public Weapons Slot3
			{
				get => (Weapons)new MCAPI().Extension.ReadInt16(Pointer + 4);
				set => new MCAPI().Extension.WriteInt16(Pointer + 4, (short)value);
			}

			public Weapons Slot4
			{
				get => (Weapons)new MCAPI().Extension.ReadInt16(Pointer + 6);
				set => new MCAPI().Extension.WriteInt16(Pointer + 6, (short)value);
			}

			public Weapons Slot5
			{
				get => (Weapons)new MCAPI().Extension.ReadInt16(Pointer + 8);
				set => new MCAPI().Extension.WriteInt16(Pointer + 8, (short)value);
			}

			public Weapon_s(uint Base)
				=> Pointer = Base;
		}

		public class Item_s
		{
			private uint Pointer;

			public Items Slot1
			{
				get
				{
					return (Items)new MCAPI().Extension.ReadInt16(Pointer);
				}
				set
				{
					new MCAPI().Extension.WriteInt16(Pointer, (short)value);
				}
			}

			public Items Slot2
			{
				get
				{
					return (Items)new MCAPI().Extension.ReadInt16(Pointer + 2);
				}
				set
				{
					new MCAPI().Extension.WriteInt16(Pointer + 2, (short)value);
				}
			}

			public Items Slot3
			{
				get
				{
					return (Items)new MCAPI().Extension.ReadInt16(Pointer + 4);
				}
				set
				{
					new MCAPI().Extension.WriteInt16(Pointer + 4, (short)value);
				}
			}

			public Items Slot4
			{
				get
				{
					return (Items)new MCAPI().Extension.ReadInt16(Pointer + 6);
				}
				set
				{
					new MCAPI().Extension.WriteInt16(Pointer + 6, (short)value);
				}
			}

			public Items Slot5
			{
				get
				{
					return (Items)new MCAPI().Extension.ReadInt16(Pointer + 8);
				}
				set
				{
					new MCAPI().Extension.WriteInt16(Pointer + 8, (short)value);
				}
			}

			public Items Slot6
			{
				get
				{
					return (Items)new MCAPI().Extension.ReadInt16(Pointer + 10);
				}
				set
				{
					new MCAPI().Extension.WriteInt16(Pointer + 10, (short)value);
				}
			}

			public Items Slot7
			{
				get
				{
					return (Items)new MCAPI().Extension.ReadInt16(Pointer + 12);
				}
				set
				{
					new MCAPI().Extension.WriteInt16(Pointer + 12, (short)value);
				}
			}

			public Items Slot8
			{
				get
				{
					return (Items)new MCAPI().Extension.ReadInt16(Pointer + 14);
				}
				set
				{
					new MCAPI().Extension.WriteInt16(Pointer + 14, (short)value);
				}
			}

			public Item_s(uint Base)
			{
				Pointer = Base;
			}
		}

		public Weapon_s WeaponSlot;

		public Item_s ItemSlot;

		public Inv()
		{
			uint num;
			num = new MCAPI().Extension.ReadUInt32(0x003EC730);
			WeaponSlot = new Weapon_s(num + 2724);
			ItemSlot = new Item_s(num + 2740);
		}
	}

}
