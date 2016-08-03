namespace RoushTech.Website.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class BlogController : Controller
    {
        [Route("/blog")]
        [Route("/2016/05/21/server-urls-paramter-working-kestrel-server-dotnet-command-asp-net-core-rc2/")]
        [Route("/2016/04/18/asp-net-core-huge/")]
        [Route("/2016/04/17/backing-snapshots-vmware/")]
        [Route("/2016/04/13/rhodecode-self-hosted-source-code-repository-showdown/")]
        [Route("/2016/04/13/exchange-imap-ssl-working/")]
        [Route("/2016/04/06/unable-revert-snapshot-the-vendor-processors-machine-same/")]
        [Route("/2016/04/06/consolidate-disks-vmware/")]
        [Route("/2016/03/18/octopack-asp-net-core/")]
        [Route("/2016/01/20/fixing-invalid-expired-security-content-token/")]
        [Route("/2015/10/20/simplehelp-review-self-hosted-remote-support-software/")]
        [Route("/2015/10/19/screenconnect-pricing/")]
        [Route("/2015/06/26/gogs-self-hosted-source-code-repository-review/")]
        [Route("/2015/04/19/introduction-self-hosted-source-code-repository-showdown/")]
        [Route("/2015/01/25/teamcity-vsphere-esxi-integration-explained/")]
        [Route("/2014/12/28/republic-wireless-customers-review/")]
        [Route("/2014/12/28/invision-power-revokes-perpetuallifetime-licensing-thoughts/")]
        [Route("/2014/09/08/intuitive-password-online-password-management-review/")]
        [Route("/2014/08/28/upsource-preview-repository-management-review-jetbrains/")]
        [Route("/2014/08/04/vmware-web-client-awesome/")]
        [Route("/2014/07/16/screenconnect-review/")]
        [Route("/2014/05/30/passwordstate-enterprise-password-management-review/")]
        [Route("/2014/04/01/100-qualys-ssl-test-a/")]
        [Route("/2014/03/26/dan-kaminsky-black-ops-pki/")]
        [Route("/2014/03/20/solid-state-drives-robust-spinning-rust/")]
        [Route("/2014/02/19/pci-compliant-screenconnect-setup-nginx/")]
        [Route("/2014/01/19/statically-compiled-linq-queries-broken-in-net-4-0/")]
        [Route("/2014/01/13/you-may-pay-even-if-you-do-everything-right-cryptolocker/")]
        [Route("/2013/12/30/vmware-distributed-power-management-dpm-action/")]
        [Route("/2013/12/17/windows-vault-store-tortoisehg-mercurial-passwords/")]
        [Route("/2013/12/02/bittorrent-sync-decentralized-cloud-file-sharing/")]
        [Route("/2013/11/18/intro-ssds-lopsa-east-2013-matt-simmons/")]
        [Route("/2013/11/18/wiztree-fast-replacement-windirstat/")]
        [Route("/2013/11/13/cryptolocker-the-dreaded-trojan-horse-malware-thatll-put-your-company-at-risk/")]
        [Route("/2013/11/12/vsphere-memory-management/")]
        [Route("/2013/11/11/password-security-using-keepass-password-safe-and-a-small-list-of-similar-software/")]
        [Route("/2013/11/04/tamper-proof-licensing-using-cryptographic-signatures/")]
        [Route("/2013/10/30/high-performance-event-log-reading/")]
        [Route("/2013/10/21/interview-with-robert-c-martin-programmerauthor/")]
        [Route("/2013/03/25/osx-apple-remote-desktop-active-directory-logins-from-a-windows-client-remotix/")]
        [Route("/2011/07/16/vmware-vsphere-5-licensing/")]
        [Route("/2014/01/13/pay/")]
        [Route("/2015/10/20/simplehelp-self-hosted-remote-support-software/")]
        [Route("/2014/01/13/depend-antivirusidsipsfirewalletc-protect-cryptolocker/")]
        [Route("/tech-blog/10-virtualization/17-vmware-vsphere-5-licensing")]
        [Route("/tech-blog/19-osx-apple-remote-desktop-active-directory-logins-from-a-windows-client-remotix")]
        public Task<IActionResult> Redirect()
        {
            return Task.FromResult<IActionResult>(this.RedirectPermanent($"https://blog.roushtech.net{Request.Path}"));
        }
    }
}
