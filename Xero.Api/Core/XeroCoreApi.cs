﻿using System.Collections.Generic;
using System.Linq;
using Xero.Api.Common;
using Xero.Api.Core.Endpoints;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Setup;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.RateLimiter;
using Xero.Api.Serialization;
using Organisation = Xero.Api.Core.Model.Organisation;

namespace Xero.Api.Core
{
    public class XeroCoreApi : XeroApi, IXeroCoreApi
    {
        private IOrganisationEndpoint OrganisationEndpoint { get; set; }

        public XeroCoreApi(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user,
            IJsonObjectMapper readMapper, IXmlObjectMapper writeMapper)
            : this(baseUri, auth, consumer, user, readMapper, writeMapper, null)
        {
        }

        public XeroCoreApi(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user, IJsonObjectMapper readMapper, IXmlObjectMapper writeMapper, IRateLimiter rateLimiter)
            : base(baseUri, auth, consumer, user, readMapper, writeMapper, rateLimiter)
        {
            Connect();
        }

        public XeroCoreApi(string baseUri, ICertificateAuthenticator auth, IConsumer consumer, IUser user,
            IJsonObjectMapper readMapper, IXmlObjectMapper writeMapper)
            : this(baseUri, auth, consumer, user, readMapper, writeMapper, null)
        {
        }

        public XeroCoreApi(string baseUri, ICertificateAuthenticator auth, IConsumer consumer, IUser user, IJsonObjectMapper readMapper, IXmlObjectMapper writeMapper, IRateLimiter rateLimiter)
            : base(baseUri, auth, consumer, user, readMapper, writeMapper, rateLimiter)
        {
            Connect();
        }

        public XeroCoreApi(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user)
            : this(baseUri, auth, consumer, user, null)
        {
        }

        public XeroCoreApi(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user, IRateLimiter rateLimiter)
            : this(baseUri, auth, consumer, user, new DefaultMapper(), new DefaultMapper())
        {
        }

        public XeroCoreApi(string baseUri, ICertificateAuthenticator auth, IConsumer consumer, IUser user)
            : this(baseUri, auth, consumer, user, null)
        {
        }

        public XeroCoreApi(string baseUri, ICertificateAuthenticator auth, IConsumer consumer, IUser user, IRateLimiter rateLimiter)
            : this(baseUri, auth, consumer, user, new DefaultMapper(), new DefaultMapper(), rateLimiter)
        {
        }

        public IAccountsEndpoint Accounts { get; private set; }
        public AllocationsEndpoint Allocations { get; private set; }
        public AttachmentsEndpoint Attachments { get; private set; }
        public IBankTransactionsEndpoint BankTransactions { get; private set; }
        public IBankTransfersEndpoint BankTransfers { get; private set; }
        public IBrandingThemesEndpoint BrandingThemes { get; private set; }
        public IContactsEndpoint Contacts { get; private set; }
        public IContactGroupsEndpoint ContactGroups { get; private set;}
        public ICreditNotesEndpoint CreditNotes { get; private set; }
        public ICurrenciesEndpoint Currencies { get; set; }
        public EmployeesEndpoint Employees { get; private set; }
        public ExpenseClaimsEndpoint ExpenseClaims { get; private set; }
        public FilesEndpoint Files { get; private set; }
        public FoldersEndpoint Folders { get; private set; }
        public InboxEndpoint Inbox { get; private set; }
        public InvoicesEndpoint Invoices { get; private set; }
        public ItemsEndpoint Items { get; private set; }
        public IJournalsEndpoint Journals { get; protected set; }
        public LinkedTransactionsEndpoint LinkedTransactions { get; private set; }
        public ManualJournalsEndpoint ManualJournals { get; private set; }
        public OverpaymentsEndpoint Overpayments { get; private set; }
        public PaymentsEndpoint Payments { get; private set; }
        public PdfEndpoint PdfFiles { get; private set; }
        public PrepaymentsEndpoint Prepayments { get; private set; }
        public PurchaseOrdersEndpoint PurchaseOrders { get; private set; }
        public ReceiptsEndpoint Receipts { get; private set; }
        public RepeatingInvoicesEndpoint RepeatingInvoices { get; private set; }
        public ReportsEndpoint Reports { get; private set; }
        public SetupEndpoint Setup { get; private set; }
        public TaxRatesEndpoint TaxRates { get; private set; }
        public TrackingCategoriesEndpoint TrackingCategories { get; private set; }
        public UsersEndpoint Users { get; private set; }
        

        private void Connect()
        {
            OrganisationEndpoint = new OrganisationEndpoint(Client);

            Accounts = new AccountsEndpoint(Client);
            Allocations = new AllocationsEndpoint(Client);
            Attachments = new AttachmentsEndpoint(Client);
            BankTransactions = new BankTransactionsEndpoint(Client);
            BankTransfers = new BankTransfersEndpoint(Client);
            BrandingThemes = new BrandingThemesEndpoint(Client);
            Contacts = new ContactsEndpoint(Client);
            ContactGroups = new ContactGroupsEndpoint(Client);
            CreditNotes = new CreditNotesEndpoint(Client);
            Currencies = new CurrenciesEndpoint(Client);
            Employees = new EmployeesEndpoint(Client);
            ExpenseClaims = new ExpenseClaimsEndpoint(Client);
            Files = new FilesEndpoint(Client);
            Folders = new FoldersEndpoint(Client);
            Inbox = new InboxEndpoint(Client);
            Invoices = new InvoicesEndpoint(Client);
            Items = new ItemsEndpoint(Client);
            Journals = new JournalsEndpoint(Client);
            LinkedTransactions = new LinkedTransactionsEndpoint(Client);
            ManualJournals = new ManualJournalsEndpoint(Client);
            Overpayments = new OverpaymentsEndpoint(Client);
            Payments = new PaymentsEndpoint(Client);
            PdfFiles = new PdfEndpoint(Client);
            Prepayments = new PrepaymentsEndpoint(Client);
            PurchaseOrders = new PurchaseOrdersEndpoint(Client);
            Receipts = new ReceiptsEndpoint(Client);
            RepeatingInvoices = new RepeatingInvoicesEndpoint(Client);
            Reports = new ReportsEndpoint(Client);
            Setup = new SetupEndpoint(Client);
            TaxRates = new TaxRatesEndpoint(Client);
            TrackingCategories = new TrackingCategoriesEndpoint(Client);
            Users = new UsersEndpoint(Client);
        }

        public Organisation Organisation
        {
            get
            {
                return OrganisationEndpoint.Find().FirstOrDefault();
            }
        }

        public IEnumerable<Invoice> Create(IEnumerable<Invoice> items)
        {
            return Invoices.Create(items);
        }

        public IEnumerable<Contact> Create(IEnumerable<Contact> items)
        {
            return Contacts.Create(items);
        }
        
        public IEnumerable<Account> Create(IEnumerable<Account> items)
        {
            return Accounts.Create(items);
        }

        public IEnumerable<Employee> Create(IEnumerable<Employee> items)
        {
            return Employees.Create(items);
        }

        public IEnumerable<ExpenseClaim> Create(IEnumerable<ExpenseClaim> items)
        {
            return ExpenseClaims.Create(items);
        }

        public IEnumerable<Receipt> Create(IEnumerable<Receipt> items)
        {
            return Receipts.Create(items);
        }

        public IEnumerable<CreditNote> Create(IEnumerable<CreditNote> items)
        {
            return CreditNotes.Create(items);
        }

        public IEnumerable<Item> Create(IEnumerable<Item> items)
        {
            return Items.Create(items);
        }

        public IEnumerable<ManualJournal> Create(IEnumerable<ManualJournal> items)
        {
            return ManualJournals.Create(items);
        }

        public IEnumerable<Payment> Create(IEnumerable<Payment> items)
        {
            return Payments.Create(items);
        }

        public IEnumerable<TaxRate> Create(IEnumerable<TaxRate> items)
        {
            return TaxRates.Create(items);
        }

        public IEnumerable<BankTransaction> Create(IEnumerable<BankTransaction> items)
        {
            return BankTransactions.Create(items);
        }

        public IEnumerable<BankTransfer> Create(IEnumerable<BankTransfer> items)
        {
            return BankTransfers.Create(items);
        }

        public Invoice Create(Invoice item)
        {
            return Invoices.Create(item);
        }

        public Contact Create(Contact item)
        {
            return Contacts.Create(item);
        }

        public Account Create(Account item)
        {
            return Accounts.Create(item);
        }

        public Employee Create(Employee item)
        {
            return Employees.Create(item);
        }

        public ExpenseClaim Create(ExpenseClaim item)
        {
            return ExpenseClaims.Create(item);
        }

        public Receipt Create(Receipt item)
        {
            return Receipts.Create(item);
        }

        public CreditNote Create(CreditNote item)
        {
            return CreditNotes.Create(item);
        }

        public Item Create(Item item)
        {
            return Items.Create(item);
        }

        public ManualJournal Create(ManualJournal item)
        {
            return ManualJournals.Create(item);
        }

        public Payment Create(Payment item)
        {
            return Payments.Create(item);
        }

        public TaxRate Create(TaxRate item)
        {
            return TaxRates.Create(item);
        }

        public BankTransaction Create(BankTransaction item)
        {
            return BankTransactions.Create(item);
        }

        public BankTransfer Create(BankTransfer item)
        {
            return BankTransfers.Create(item);
        }

        public ImportSummary Create(Setup item)
        {
            return Setup.Create(item);
        }

        public Invoice Update(Invoice item)
        {
            return Invoices.Update(item);
        }

        public Contact Update(Contact item)
        {
            return Contacts.Update(item);
        }

        public ContactGroup Update(ContactGroup item)
        {
            return ContactGroups.Update(item);
        }

        public Employee Update(Employee item)
        {
            return Employees.Update(item);
        }

        public ExpenseClaim Update(ExpenseClaim item)
        {
            return ExpenseClaims.Update(item);
        }

        public Receipt Update(Receipt item)
        {
            return Receipts.Update(item);
        }

        public CreditNote Update(CreditNote item)
        {
            return CreditNotes.Update(item);
        }

        public Item Update(Item item)
        {
            return Items.Update(item);
        }

        public ManualJournal Update(ManualJournal item)
        {
            return ManualJournals.Update(item);
        }

        public BankTransaction Update(BankTransaction item)
        {
            return BankTransactions.Update(item);
        }

        public BankTransfer Update(BankTransfer item)
        {
            return BankTransfers.Update(item);
        }

        public TaxRate Update(TaxRate item)
        {
            return TaxRates.Update(item);
        }

        public ImportSummary Update(Setup item)
        {
            return Setup.Update(item);
        }

        public TrackingCategory Update(TrackingCategory item)
        {
            return TrackingCategories.Update(item);
        }
        
    }
}
