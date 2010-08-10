﻿#region License

//
// Author: Javier Lozano <javier@lozanotek.com>
// Copyright (c) 2009-2010, lozanotek, inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

#endregion

namespace Mappings {
	using FluentNHibernate.Mapping;
	using SomeModel;

	public sealed class AddressMap : ClassMap<Address> {
		public AddressMap() {
			Table("Addresses");

			Id(x => x.Id)
				.GeneratedBy.Identity();

			Map(x => x.City);
			Map(x => x.Line1);
			Map(x => x.Line2);
			Map(x => x.State);
			Map(x => x.Zip);

			Not.LazyLoad();
		}
	}
}
