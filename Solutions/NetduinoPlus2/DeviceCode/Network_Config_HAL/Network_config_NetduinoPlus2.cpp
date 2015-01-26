////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#include <tinyhal.h>

//--//

#if defined(ADS_LINKER_BUG__NOT_ALL_UNUSED_VARIABLES_ARE_REMOVED)
#pragma arm section zidata = "g_NetworkConfig_NetduinoPlus2"
#endif


NETWORK_CONFIG g_NetworkConfig =
{
    { TRUE },
    1,      // interface count
    {       
        {                                      
            SOCK_NETWORKCONFIGURATION_FLAGS_DHCP | SOCK_NETWORKCONFIGURATION_FLAGS_DYNAMIC_DNS | SOCK_NETWORKCONFIGURATION_FLAGS_EXTENDED,         /*flags         to enable wireless bitwise OR this value with  SOCK_NETWORKCONFIGURATION_FLAGS_TYPE__set(SOCK_NETWORKCONFIGURATION_FLAGS_WIRELESS)*/  
            SOCK_MAKE_IP_ADDR_LITTLEEND(192,168,  5,100), /*ip address */  
            SOCK_MAKE_IP_ADDR_LITTLEEND(255,255,255,  0), /*subnet mask*/  
            SOCK_MAKE_IP_ADDR_LITTLEEND(192,168,  5,  1), /*gateway    */  
            SOCK_MAKE_IP_ADDR_LITTLEEND(  0,  0,  0,  0), /*dns1       */  
            SOCK_MAKE_IP_ADDR_LITTLEEND(  0,  0,  0,  0), /*dns2       */  
            SOCK_NETWORKCONFIGURATION_INTERFACETYPE_ETHERNET,        /* Change to SOCK_NETWORKCONFIGURATION_INTERFACETYPE_WIRELESS_80211 for wireless */ 
            6,              /*mac address length*/                  
            {               /*mac address*/                         
                0x5C, 0x86, 0x4A, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
                0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
                0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
                0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
            }                                                       
        },                                                          
    },
};

NETWORK_CONFIG_EXTENDED g_NetworkConfigExtended =
{
    { TRUE },
    1,      // interface count
    {       
        {                                      
            SOCK_NETWORKCONFIGURATIONEXT_FLAGS_DHCPV6_IPADDR | SOCK_NETWORKCONFIGURATIONEXT_FLAGS_DHCPV6_DNSADDRS | SOCK_NETWORKCONFIGURATIONEXT_FLAGS_IPV4_SUPPORTED | SOCK_NETWORKCONFIGURATIONEXT_FLAGS_IPV6_SUPPORTED,
            {               /*ipv6 ip address*/
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            },
            0,              /*ipv6 subnet prefix length*/
            {               /*ipv6 gateway*/                         
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
            },
            {               /*ipv6 dns1*/                         
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
            },
            {               /*ipv6 dns2*/                         
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
            }
        },                                                          
    },
};

WIRELESS_CONFIG g_WirelessConfig = 
{
    /// This is a sample only.
    { TRUE },
    1,
    {
        {
            WIRELESS_FLAG_AUTHENTICATION__set(WIRELESS_FLAG_AUTHENTICATION_EAP)              |
            WIRELESS_FLAG_ENCRYPTION__set    (WIRELESS_FLAG_ENCRYPTION_WPA)                  |
            WIRELESS_FLAG_RADIO__set         (WIRELESS_FLAG_RADIO_b | WIRELESS_FLAG_RADIO_g),

            {
                'P','A','S','S','P','H','R','A','S','E','\0',
            },
            8,
            { 
                0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
                0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
                0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
                0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 
            },
            0,
            {
                0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
            },
            {
                'S','S','I','D','_','1','\0',
            },
        },
    },
};

#if defined(ADS_LINKER_BUG__NOT_ALL_UNUSED_VARIABLES_ARE_REMOVED)
#pragma arm section zidata
#endif



