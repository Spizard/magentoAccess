﻿using MagentoAccess.Models.Services.Credentials;

namespace MagentoAccess
{
	public interface IMagentoFactory
	{
		IMagentoService CreateService( MagentoAuthenticatedUserCredentials userAuthCredentials );

		IMagentoService CreateService( MagentoNonAuthenticatedUserCredentials userNonAuthCredentials );
	}
}