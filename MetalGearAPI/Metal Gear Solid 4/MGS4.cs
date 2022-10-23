using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiLib;

namespace MetalGearAPI
{
	public class MGS4
	{
		private uint BasePointer => new MCAPI().Extension.ReadUInt32(0x003EC730);
		private uint weapPointer => (this.BasePointer + 0xAA4);
		private uint itemPointer => (this.BasePointer + 0xAA4);
		public Buttons getKey => (Buttons)new MCAPI().Extension.ReadUInt32(7144584u);

		public string PressedKey => Enum.GetName(typeof(Buttons), new MCAPI().Extension.ReadUInt32(7144584u));

		public struct cDisguise
		{
			public string Name;

			public Costumes Costumes;

			public cDisguise(Costumes a)
			{
				Name = Enum.GetName(typeof(Costumes), a);
				Costumes = a;
			}

			public cDisguise(int a)
			{
				Name = Enum.GetName(typeof(Costumes), a);
				Costumes = (Costumes)a;
			}
		}

		public struct fCamo
		{
			public string Name;

			public FaceCamo FaceCamo;

			public fCamo(FaceCamo a)
			{
				Name = Enum.GetName(typeof(FaceCamo), a);
				FaceCamo = a;
			}

			public fCamo(int a)
			{
				Name = Enum.GetName(typeof(FaceCamo), a);
				FaceCamo = (FaceCamo)a;
			}
		}
		public fCamo Face
		{
			get => new fCamo((FaceCamo)new MCAPI().Extension.ReadByte(BasePointer + 2855));
			set => new MCAPI().Extension.WriteByte(BasePointer + 2855, (byte)value.FaceCamo);
		}
		public cDisguise Costume
		{
			get => new cDisguise((Costumes)new MCAPI().Extension.ReadByte(BasePointer + 2854));
			set => new MCAPI().Extension.WriteByte(BasePointer + 2854, (byte)value.Costumes);
		}

		public short Health
		{
			get => new MCAPI().Extension.ReadInt16(BasePointer + 0xB48);
			set => new MCAPI().Extension.WriteInt16(BasePointer + 0xB48, value);
		}
		public short MaxHealth
		{
			get => new MCAPI().Extension.ReadInt16(BasePointer + 0xB4A);
			set => new MCAPI().Extension.WriteInt16(BasePointer + 0xB4A, value);
		}
		public short Stamina
		{
			get => new MCAPI().Extension.ReadInt16(BasePointer + 0xB4C);
			set => new MCAPI().Extension.WriteInt16(BasePointer + 0xB4C, value);
		}
		public short MaxStamina
		{
			get => new MCAPI().Extension.ReadInt16(BasePointer + 0xB4E);
			set => new MCAPI().Extension.WriteInt16(BasePointer + 0xB4E, value);
		}
		public short Stress
		{
			get => new MCAPI().Extension.ReadInt16(BasePointer + 0xB50);
			set => new MCAPI().Extension.WriteInt16(BasePointer + 0xB50, value);
		}
		public short MaxStress
		{
			get => new MCAPI().Extension.ReadInt16(BasePointer + 0xB52);
			set => new MCAPI().Extension.WriteInt16(BasePointer + 0xB52, value);
		}
		public bool CombatHigh
		{
			get => new MCAPI().Extension.ReadInt16(BasePointer + 0xB6C) == 100;
			set => new MCAPI().Extension.WriteInt16(BasePointer + 0xB6C, (short)(value ? 100 : 0));
		}
		public int DrebinPoints
		{
			get => new MCAPI().Extension.ReadInt32(BasePointer + 0x1C0);
			set => new MCAPI().Extension.WriteInt32(BasePointer + 0x1C0, value);
		}
		public Weapons wSlot1
		{
			get => (Weapons)new MCAPI().Extension.ReadInt16(weapPointer);
			set => new MCAPI().Extension.WriteInt16(weapPointer, (short)value);
		}

		public Weapons wSlot2
		{
			get => (Weapons)new MCAPI().Extension.ReadInt16(weapPointer + 2);
			set => new MCAPI().Extension.WriteInt16(weapPointer + 2, (short)value);
		}

		public Weapons wSlot3
		{
			get => (Weapons)new MCAPI().Extension.ReadInt16(weapPointer + 4);
			set => new MCAPI().Extension.WriteInt16(weapPointer + 4, (short)value);
		}

		public Weapons wSlot4
		{
			get => (Weapons)new MCAPI().Extension.ReadInt16(weapPointer + 6);
			set => new MCAPI().Extension.WriteInt16(weapPointer + 6, (short)value);
		}

		public Weapons wSlot5
		{
			get => (Weapons)new MCAPI().Extension.ReadInt16(weapPointer + 8);
			set => new MCAPI().Extension.WriteInt16(weapPointer + 8, (short)value);
		}

		public Weapon_t CurrentWeapon => new Weapon_t(new MCAPI().Extension.ReadUInt32(5825944u));
		public Item_t CurrentItem => new Item_t(new MCAPI().Extension.ReadUInt32(5825948u));

		public MGS4()
		{
			items = new Item();
			Weapons = new Weapon();
		}

		public Item items;
		public Weapon Weapons;

		/// <summary>
		/// Needs to be Constantly written
		/// </summary>
		public string Level
		{
			get => new MCAPI().Extension.ReadString(BasePointer + 0x34);
			set => new MCAPI().Extension.WriteString(BasePointer + 0x34, value);
		}

		public void UnlockAll(bool infammo = false)
		{
			items.UnlockItems();
			Weapons.UnlockWeapons();
			if (infammo) Weapons.InfiniteAmmoAll = iAmmo_f.Both;
		}

		public void DemiGod()
		{
			MaxHealth = short.MaxValue;
			Health = MaxHealth;
			MaxStamina = short.MaxValue;
			Stamina = MaxStamina;
		}
		public string HealthPercentage
		{
			get
			{
				double per = (double)Health / MaxHealth;
				return $"{per:0.0%}";
			}
		}
	}
	 

}
