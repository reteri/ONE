import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'One',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44365',
    redirectUri: baseUrl,
    clientId: 'ONE_App',
    responseType: 'code',
    scope: 'offline_access IdentityService AdministrationService SaaSService role email openid profile',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44364',
      rootNamespace: 'One',
    },
    One: {
      url: 'https://localhost:44350',
      rootNamespace: 'One',
    },
  },
} as Environment;
