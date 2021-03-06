// Generated by Haxe 4.1.2

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	public class StringMap<T> : global::haxe.lang.HxObject, global::haxe.ds.StringMap, global::haxe.IMap<string, T> {
		
		public StringMap(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public StringMap() {
			global::haxe.ds.StringMap<object>.__hx_ctor_haxe_ds_StringMap<T>(((global::haxe.ds.StringMap<T>) (this) ));
		}
		
		
		protected static void __hx_ctor_haxe_ds_StringMap<T_c>(global::haxe.ds.StringMap<T_c> __hx_this) {
			unchecked {
				__hx_this.cachedIndex = -1;
			}
		}
		
		
		public static object __hx_cast<T_c_c>(global::haxe.ds.StringMap me) {
			return ( (( me != null )) ? (me.haxe_ds_StringMap_cast<T_c_c>()) : default(object) );
		}
		
		
		public virtual object haxe_ds_StringMap_cast<T_c>() {
			unchecked {
				if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
					return this;
				}
				
				global::haxe.ds.StringMap<T_c> new_me = new global::haxe.ds.StringMap<T_c>(global::haxe.lang.EmptyObject.EMPTY);
				global::Array<string> fields = global::Reflect.fields(this);
				int i = 0;
				while (( i < fields.length )) {
					string field = fields[i++];
					switch (field) {
						case "vals":
						{
							if (( this.vals != null )) {
								T_c[] __temp_new_arr1 = new T_c[this.vals.Length];
								int __temp_i2 = -1;
								while ((  ++ __temp_i2 < this.vals.Length )) {
									object __temp_obj3 = ((object) (this.vals[__temp_i2]) );
									if (( __temp_obj3 != null )) {
										__temp_new_arr1[__temp_i2] = global::haxe.lang.Runtime.genericCast<T_c>(__temp_obj3);
									}
									
								}
								
								new_me.vals = __temp_new_arr1;
							}
							else {
								new_me.vals = null;
							}
							
							break;
						}
						
						
						default:
						{
							global::Reflect.setField(new_me, field, global::Reflect.field(this, field));
							break;
						}
						
					}
					
				}
				
				return new_me;
			}
		}
		
		
		public virtual object haxe_IMap_cast<K_c, V_c>() {
			return this.haxe_ds_StringMap_cast<T>();
		}
		
		
		public int[] hashes;
		
		public string[] _keys;
		
		public T[] vals;
		
		public int nBuckets;
		
		public int size;
		
		public int nOccupied;
		
		public int upperBound;
		
		public string cachedKey;
		
		public int cachedIndex;
		
		public virtual void @set(string key, T @value) {
			unchecked {
				int x = default(int);
				int k = default(int);
				if (( this.nOccupied >= this.upperBound )) {
					if (( this.nBuckets > ( this.size << 1 ) )) {
						this.resize(( this.nBuckets - 1 ));
					}
					else {
						this.resize(( this.nBuckets + 2 ));
					}
					
				}
				
				int[] hashes = this.hashes;
				string[] keys = this._keys;
				int[] hashes1 = hashes;
				{
					int mask = ( (( this.nBuckets == 0 )) ? (0) : (( this.nBuckets - 1 )) );
					x = this.nBuckets;
					int site = x;
					int k1 = key.GetHashCode();
					k1 = ( ( k1 + 2127912214 ) + (( k1 << 12 )) );
					k1 = ( ( k1 ^ -949894596 ) ^ ( k1 >> 19 ) );
					k1 = ( ( k1 + 374761393 ) + (( k1 << 5 )) );
					k1 = ( ( k1 + (-744332180) ) ^ ( k1 << 9 ) );
					k1 = ( ( k1 + (-42973499) ) + (( k1 << 3 )) );
					k1 = ( ( k1 ^ -1252372727 ) ^ ( k1 >> 16 ) );
					int ret = k1;
					if (( (( ret & -2 )) == 0 )) {
						if (( ret == 0 )) {
							ret = 2;
						}
						else {
							ret = -1;
						}
						
					}
					
					k = ret;
					int i = ( k & mask );
					int nProbes = 0;
					int delKey = -1;
					if (( hashes1[i] == 0 )) {
						x = i;
					}
					else {
						int last = i;
						int flag = default(int);
						while (true) {
							flag = hashes1[i];
							if (( ( flag == 0 ) || ( ( flag == k ) && ( ((string) (this._keys[i]) ) == key ) ) )) {
								break;
							}
							
							if (( ( flag == 1 ) && ( delKey == -1 ) )) {
								delKey = i;
							}
							
							i = ( ( i +  ++ nProbes ) & mask );
						}
						
						if (( ( flag == 0 ) && ( delKey != -1 ) )) {
							x = delKey;
						}
						else {
							x = i;
						}
						
					}
					
				}
				
				int flag1 = hashes1[x];
				if (( flag1 == 0 )) {
					keys[x] = key;
					this.vals[x] = @value;
					hashes1[x] = k;
					this.size++;
					this.nOccupied++;
				}
				else if (( flag1 == 1 )) {
					keys[x] = key;
					this.vals[x] = @value;
					hashes1[x] = k;
					this.size++;
				}
				else {
					this.vals[x] = @value;
				}
				
				this.cachedIndex = x;
				this.cachedKey = key;
			}
		}
		
		
		public int lookup(string key) {
			unchecked {
				if (( this.nBuckets != 0 )) {
					int[] hashes = this.hashes;
					string[] keys = this._keys;
					int mask = ( this.nBuckets - 1 );
					int k = key.GetHashCode();
					k = ( ( k + 2127912214 ) + (( k << 12 )) );
					k = ( ( k ^ -949894596 ) ^ ( k >> 19 ) );
					k = ( ( k + 374761393 ) + (( k << 5 )) );
					k = ( ( k + (-744332180) ) ^ ( k << 9 ) );
					k = ( ( k + (-42973499) ) + (( k << 3 )) );
					k = ( ( k ^ -1252372727 ) ^ ( k >> 16 ) );
					int ret = k;
					if (( (( ret & -2 )) == 0 )) {
						if (( ret == 0 )) {
							ret = 2;
						}
						else {
							ret = -1;
						}
						
					}
					
					int hash = ret;
					int k1 = hash;
					int nProbes = 0;
					int i = ( k1 & mask );
					int last = i;
					int flag = default(int);
					while (true) {
						flag = hashes[i];
						if ( ! ((( ( flag != 0 ) && (( ( ( flag == 1 ) || ( flag != k1 ) ) || ( ((string) (keys[i]) ) != key ) )) ))) ) {
							break;
						}
						
						i = ( ( i +  ++ nProbes ) & mask );
					}
					
					if (( (( flag & -2 )) == 0 )) {
						return -1;
					}
					else {
						return i;
					}
					
				}
				
				return -1;
			}
		}
		
		
		public void resize(int newNBuckets) {
			unchecked {
				int[] newHash = null;
				int j = 1;
				{
					int x = newNBuckets;
					 -- x;
					x |= ((int) (( ((uint) (x) ) >> 1 )) );
					x |= ((int) (( ((uint) (x) ) >> 2 )) );
					x |= ((int) (( ((uint) (x) ) >> 4 )) );
					x |= ((int) (( ((uint) (x) ) >> 8 )) );
					x |= ((int) (( ((uint) (x) ) >> 16 )) );
					 ++ x;
					newNBuckets = x;
					if (( newNBuckets < 4 )) {
						newNBuckets = 4;
					}
					
					if (( this.size >= ( ( newNBuckets * 0.77 ) + 0.5 ) )) {
						j = 0;
					}
					else {
						int nfSize = newNBuckets;
						newHash = new int[nfSize];
						if (( this.nBuckets < newNBuckets )) {
							string[] k = new string[newNBuckets];
							if (( this._keys != null )) {
								global::System.Array.Copy(((global::System.Array) (this._keys) ), ((int) (0) ), ((global::System.Array) (k) ), ((int) (0) ), ((int) (this.nBuckets) ));
							}
							
							this._keys = k;
							T[] v = new T[newNBuckets];
							if (( this.vals != null )) {
								global::System.Array.Copy(((global::System.Array) (this.vals) ), ((int) (0) ), ((global::System.Array) (v) ), ((int) (0) ), ((int) (this.nBuckets) ));
							}
							
							this.vals = v;
						}
						
					}
					
				}
				
				if (( j != 0 )) {
					this.cachedKey = null;
					this.cachedIndex = -1;
					j = -1;
					int nBuckets = this.nBuckets;
					string[] _keys = this._keys;
					T[] vals = this.vals;
					int[] hashes = this.hashes;
					int newMask = ( newNBuckets - 1 );
					while ((  ++ j < nBuckets )) {
						int k1 = hashes[j];
						if (( (( k1 & -2 )) != 0 )) {
							string key = ((string) (_keys[j]) );
							T val = global::haxe.lang.Runtime.genericCast<T>(vals[j]);
							_keys[j] = null;
							vals[j] = default(T);
							hashes[j] = 1;
							while (true) {
								int nProbes = 0;
								int i = ( k1 & newMask );
								while (( newHash[i] != 0 )) {
									i = ( ( i +  ++ nProbes ) & newMask );
								}
								
								newHash[i] = k1;
								bool tmp = default(bool);
								if (( i < nBuckets )) {
									k1 = hashes[i];
									tmp = ( (( k1 & -2 )) != 0 );
								}
								else {
									tmp = false;
								}
								
								if (tmp) {
									{
										string tmp1 = ((string) (_keys[i]) );
										_keys[i] = key;
										key = tmp1;
									}
									
									{
										T tmp2 = global::haxe.lang.Runtime.genericCast<T>(vals[i]);
										vals[i] = val;
										val = tmp2;
									}
									
									hashes[i] = 1;
								}
								else {
									_keys[i] = key;
									vals[i] = val;
									break;
								}
								
							}
							
						}
						
					}
					
					if (( nBuckets > newNBuckets )) {
						{
							string[] k2 = new string[newNBuckets];
							global::System.Array.Copy(((global::System.Array) (_keys) ), ((int) (0) ), ((global::System.Array) (k2) ), ((int) (0) ), ((int) (newNBuckets) ));
							this._keys = k2;
						}
						
						{
							T[] v1 = new T[newNBuckets];
							global::System.Array.Copy(((global::System.Array) (vals) ), ((int) (0) ), ((global::System.Array) (v1) ), ((int) (0) ), ((int) (newNBuckets) ));
							this.vals = v1;
						}
						
					}
					
					this.hashes = newHash;
					this.nBuckets = newNBuckets;
					this.nOccupied = this.size;
					this.upperBound = ((int) (( ( newNBuckets * 0.77 ) + .5 )) );
				}
				
			}
		}
		
		
		public virtual global::haxe.lang.Null<T> @get(string key) {
			unchecked {
				int idx = -1;
				bool tmp = default(bool);
				if (( this.cachedKey == key )) {
					idx = this.cachedIndex;
					tmp = ( idx != -1 );
				}
				else {
					tmp = false;
				}
				
				if (tmp) {
					return new global::haxe.lang.Null<T>(global::haxe.lang.Runtime.genericCast<T>(this.vals[idx]), true);
				}
				
				idx = this.lookup(key);
				if (( idx != -1 )) {
					this.cachedKey = key;
					this.cachedIndex = idx;
					return new global::haxe.lang.Null<T>(global::haxe.lang.Runtime.genericCast<T>(this.vals[idx]), true);
				}
				
				return default(global::haxe.lang.Null<T>);
			}
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 922671056:
					{
						this.cachedIndex = ((int) (@value) );
						return @value;
					}
					
					
					case 2022294396:
					{
						this.upperBound = ((int) (@value) );
						return @value;
					}
					
					
					case 480756972:
					{
						this.nOccupied = ((int) (@value) );
						return @value;
					}
					
					
					case 1280549057:
					{
						this.size = ((int) (@value) );
						return @value;
					}
					
					
					case 1537812987:
					{
						this.nBuckets = ((int) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 922671056:
					{
						this.cachedIndex = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1395555037:
					{
						this.cachedKey = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 2022294396:
					{
						this.upperBound = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 480756972:
					{
						this.nOccupied = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1280549057:
					{
						this.size = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1537812987:
					{
						this.nBuckets = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1313416818:
					{
						this.vals = ((T[]) (@value) );
						return @value;
					}
					
					
					case 2048392659:
					{
						this._keys = ((string[]) (@value) );
						return @value;
					}
					
					
					case 995006396:
					{
						this.hashes = ((int[]) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 5144726:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get", 5144726)) );
					}
					
					
					case 142301684:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "resize", 142301684)) );
					}
					
					
					case 1639293562:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "lookup", 1639293562)) );
					}
					
					
					case 5741474:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set", 5741474)) );
					}
					
					
					case 922671056:
					{
						return this.cachedIndex;
					}
					
					
					case 1395555037:
					{
						return this.cachedKey;
					}
					
					
					case 2022294396:
					{
						return this.upperBound;
					}
					
					
					case 480756972:
					{
						return this.nOccupied;
					}
					
					
					case 1280549057:
					{
						return this.size;
					}
					
					
					case 1537812987:
					{
						return this.nBuckets;
					}
					
					
					case 1313416818:
					{
						return this.vals;
					}
					
					
					case 2048392659:
					{
						return this._keys;
					}
					
					
					case 995006396:
					{
						return this.hashes;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 922671056:
					{
						return ((double) (this.cachedIndex) );
					}
					
					
					case 2022294396:
					{
						return ((double) (this.upperBound) );
					}
					
					
					case 480756972:
					{
						return ((double) (this.nOccupied) );
					}
					
					
					case 1280549057:
					{
						return ((double) (this.size) );
					}
					
					
					case 1537812987:
					{
						return ((double) (this.nBuckets) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				switch (hash) {
					case 5144726:
					{
						return (this.@get(global::haxe.lang.Runtime.toString(dynargs[0]))).toDynamic();
					}
					
					
					case 142301684:
					{
						this.resize(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 1639293562:
					{
						return this.lookup(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 5741474:
					{
						this.@set(global::haxe.lang.Runtime.toString(dynargs[0]), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
						break;
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return null;
			}
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			baseArr.push("cachedIndex");
			baseArr.push("cachedKey");
			baseArr.push("upperBound");
			baseArr.push("nOccupied");
			baseArr.push("size");
			baseArr.push("nBuckets");
			baseArr.push("vals");
			baseArr.push("_keys");
			baseArr.push("hashes");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	[global::haxe.lang.GenericInterface(typeof(global::haxe.ds.StringMap<object>))]
	public interface StringMap : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		
		object haxe_ds_StringMap_cast<T_c>();
		
		object haxe_IMap_cast<K_c, V_c>();
		
		int lookup(string key);
		
		void resize(int newNBuckets);
		
	}
}


