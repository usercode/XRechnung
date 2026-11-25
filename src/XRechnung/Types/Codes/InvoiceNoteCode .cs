namespace XRechnung;

/// <summary>
/// Der Betreff für den nachfolgenden Textvermerk zur Rechnung. Die Auswahl erfolgt aus UNTDID 4451.
/// </summary>
public record class InvoiceNoteCode : Code
{
    /// <summary>
    /// [7002] Plain language description of the nature of a goods item sufficient to identify it for customs, statistical or transport purposes.
    /// </summary>
    public static InvoiceNoteCode GoodsItemDescription => new() { Value = "AAA" };

    /// <summary>
    /// [4276] Free form description of the conditions of payment between the parties to a transaction.
    /// </summary>
    public static InvoiceNoteCode PaymentTerm => new() { Value = "AAB" };

    /// <summary>
    /// [7488] Additional information concerning dangerous substances and/or article in a consignment.
    /// </summary>
    public static InvoiceNoteCode DangerousGoodsAdditionalInformation => new() { Value = "AAC" };

    /// <summary>
    /// [7254] Proper shipping name, supplemented as necessary with the correct technical name, by which a dangerous substance or article may be correctly identified, or which is sufficiently informative to permit identification by reference to generally available literature.
    /// </summary>
    public static InvoiceNoteCode DangerousGoodsTechnicalName => new() { Value = "AAD" };

    /// <summary>
    /// The content of an acknowledgement.
    /// </summary>
    public static InvoiceNoteCode AcknowledgementDescription => new() { Value = "AAE" };

    /// <summary>
    /// Specific details applying to rates.
    /// </summary>
    public static InvoiceNoteCode RateAdditionalInformation => new() { Value = "AAF" };

    /// <summary>
    /// Indicates that the segment contains instructions to be passed on to the identified party.
    /// </summary>
    public static InvoiceNoteCode PartyInstructions => new() { Value = "AAG" };

    /// <summary>
    /// The text contains general information.
    /// </summary>
    public static InvoiceNoteCode GeneralInformation => new() { Value = "AAI" };

    /// <summary>
    /// Additional conditions specific to this order or project.
    /// </summary>
    public static InvoiceNoteCode AdditionalConditionsOfSalePurchase => new() { Value = "AAJ" };

    /// <summary>
    /// Information on the price conditions that are expected or given.
    /// </summary>
    public static InvoiceNoteCode PriceConditions => new() { Value = "AAK" };

    /// <summary>
    /// Expression of a number in characters as length of ten meters.
    /// </summary>
    public static InvoiceNoteCode GoodsDimensionsInCharacters => new() { Value = "AAL" };

    /// <summary>
    /// Technical or commercial reasons why a piece of equipment may not be re-used after the current transport terminates.
    /// </summary>
    public static InvoiceNoteCode EquipmentReUsageRestrictions => new() { Value = "AAM" };

    /// <summary>
    /// Restrictions in handling depending on the technical characteristics of the piece of equipment or on the nature of the goods.
    /// </summary>
    public static InvoiceNoteCode HandlingRestriction => new() { Value = "AAN" };

    /// <summary>
    /// Error described by a free text.
    /// </summary>
    public static InvoiceNoteCode ErrorDescriptionFreeText => new() { Value = "AAO" };

    /// <summary>
    /// Free text of the response to a communication.
    /// </summary>
    public static InvoiceNoteCode ResponseFreeText => new() { Value = "AAP" };

    /// <summary>
    /// A description of the contents of a package.
    /// </summary>
    public static InvoiceNoteCode PackageContentSDescription => new() { Value = "AAQ" };

    /// <summary>
    /// (4053) Free text of the non Incoterms terms of delivery. For Incoterms, use: 4053.
    /// </summary>
    public static InvoiceNoteCode TermsOfDelivery => new() { Value = "AAR" };

    /// <summary>
    /// The remarks printed or to be printed on a bill of lading.
    /// </summary>
    public static InvoiceNoteCode BillOfLadingRemarks => new() { Value = "AAS" };

    /// <summary>
    /// Free text information on an IATA Air Waybill to indicate means by which account is to be settled.
    /// </summary>
    public static InvoiceNoteCode ModeOfSettlementInformation => new() { Value = "AAT" };

    /// <summary>
    /// Information pertaining to the invoice covering the consignment.
    /// </summary>
    public static InvoiceNoteCode ConsignmentInvoiceInformation => new() { Value = "AAU" };

    /// <summary>
    /// Information pertaining to the invoice covering clearance of the cargo.
    /// </summary>
    public static InvoiceNoteCode ClearanceInvoiceInformation => new() { Value = "AAV" };

    /// <summary>
    /// Information pertaining to the letter of credit.
    /// </summary>
    public static InvoiceNoteCode LetterOfCreditInformation => new() { Value = "AAW" };

    /// <summary>
    /// Information pertaining to a license.
    /// </summary>
    public static InvoiceNoteCode LicenseInformation => new() { Value = "AAX" };

    /// <summary>
    /// The text contains certification statements.
    /// </summary>
    public static InvoiceNoteCode CertificationStatements => new() { Value = "AAY" };

    /// <summary>
    /// The text contains additional export information.
    /// </summary>
    public static InvoiceNoteCode AdditionalExportInformation => new() { Value = "AAZ" };

    /// <summary>
    /// Description of parameters relating to a tariff.
    /// </summary>
    public static InvoiceNoteCode TariffStatements => new() { Value = "ABA" };

    /// <summary>
    /// Historical details of a patients medical events.
    /// </summary>
    public static InvoiceNoteCode MedicalHistory => new() { Value = "ABB" };

    /// <summary>
    /// (4490) (4372) Additional information regarding terms and conditions which apply to the transaction.
    /// </summary>
    public static InvoiceNoteCode ConditionsOfSaleOrPurchase => new() { Value = "ABC" };

    /// <summary>
    /// [4422] Textual representation of the type of contract.
    /// </summary>
    public static InvoiceNoteCode ContractDocumentType => new() { Value = "ABD" };

    /// <summary>
    /// (4260) Additional terms and/or conditions to the documentary credit.
    /// </summary>
    public static InvoiceNoteCode AdditionalTermsAndOrConditionsDocumentaryCredit => new() { Value = "ABE" };

    /// <summary>
    /// Instruction or information about a standby documentary credit.
    /// </summary>
    public static InvoiceNoteCode InstructionsOrInformationAboutStandbyDocumentaryCredit => new() { Value = "ABF" };

    /// <summary>
    /// Instructions or information about partial shipment(s).
    /// </summary>
    public static InvoiceNoteCode InstructionsOrInformationAboutPartialShipmentS => new() { Value = "ABG" };

    /// <summary>
    /// Instructions or information about transhipment(s).
    /// </summary>
    public static InvoiceNoteCode InstructionsOrInformationAboutTranshipmentS => new() { Value = "ABH" };

    /// <summary>
    /// Additional handling instructions for a documentary credit.
    /// </summary>
    public static InvoiceNoteCode AdditionalHandlingInstructionsDocumentaryCredit => new() { Value = "ABI" };

    /// <summary>
    /// Information regarding the domestic routing.
    /// </summary>
    public static InvoiceNoteCode DomesticRoutingInformation => new() { Value = "ABJ" };

    /// <summary>
    /// Equipment types are coded by category for financial purposes.
    /// </summary>
    public static InvoiceNoteCode ChargeableCategoryOfEquipment => new() { Value = "ABK" };

    /// <summary>
    /// Information pertaining to government.
    /// </summary>
    public static InvoiceNoteCode GovernmentInformation => new() { Value = "ABL" };

    /// <summary>
    /// The text contains onward routing information.
    /// </summary>
    public static InvoiceNoteCode OnwardRoutingInformation => new() { Value = "ABM" };

    /// <summary>
    /// [4410] The text contains information related to accounting.
    /// </summary>
    public static InvoiceNoteCode AccountingInformation => new() { Value = "ABN" };

    /// <summary>
    /// Free text or coded information to indicate a specific discrepancy.
    /// </summary>
    public static InvoiceNoteCode DiscrepancyInformation => new() { Value = "ABO" };

    /// <summary>
    /// Documentary credit confirmation instructions.
    /// </summary>
    public static InvoiceNoteCode ConfirmationInstructions => new() { Value = "ABP" };

    /// <summary>
    /// Method of issuance of documentary credit.
    /// </summary>
    public static InvoiceNoteCode MethodOfIssuance => new() { Value = "ABQ" };

    /// <summary>
    /// Delivery instructions for documents required under a documentary credit.
    /// </summary>
    public static InvoiceNoteCode DocumentsDeliveryInstructions => new() { Value = "ABR" };

    /// <summary>
    /// Additional conditions to the issuance of a documentary credit.
    /// </summary>
    public static InvoiceNoteCode AdditionalConditions => new() { Value = "ABS" };

    /// <summary>
    /// Additional amounts information/instruction.
    /// </summary>
    public static InvoiceNoteCode InformationInstructionsAboutAdditionalAmountsCovered => new() { Value = "ABT" };

    /// <summary>
    /// Additional terms concerning deferred payment.
    /// </summary>
    public static InvoiceNoteCode DeferredPaymentTermedAdditional => new() { Value = "ABU" };

    /// <summary>
    /// Additional terms concerning acceptance.
    /// </summary>
    public static InvoiceNoteCode AcceptanceTermsAdditional => new() { Value = "ABV" };

    /// <summary>
    /// Additional terms concerning negotiation.
    /// </summary>
    public static InvoiceNoteCode NegotiationTermsAdditional => new() { Value = "ABW" };

    /// <summary>
    /// Document name and documentary requirements.
    /// </summary>
    public static InvoiceNoteCode DocumentNameAndDocumentaryRequirements => new() { Value = "ABX" };

    /// <summary>
    /// Instructions/information about a revolving documentary credit.
    /// </summary>
    public static InvoiceNoteCode InstructionsInformationAboutRevolvingDocumentaryCredit => new() { Value = "ABZ" };

    /// <summary>
    /// Specification of the documentary requirements.
    /// </summary>
    public static InvoiceNoteCode DocumentaryRequirements => new() { Value = "ACA" };

    /// <summary>
    /// (4270) The text contains additional information.
    /// </summary>
    public static InvoiceNoteCode AdditionalInformation => new() { Value = "ACB" };

    /// <summary>
    /// Assignment based on an agreement between seller and factor.
    /// </summary>
    public static InvoiceNoteCode FactorAssignmentClause => new() { Value = "ACC" };

    /// <summary>
    /// Reason for a request or response.
    /// </summary>
    public static InvoiceNoteCode Reason => new() { Value = "ACD" };

    /// <summary>
    /// A notice, usually from buyer to seller, that something was found wrong with goods delivered or the services rendered, or with the related invoice.
    /// </summary>
    public static InvoiceNoteCode Dispute => new() { Value = "ACE" };

    /// <summary>
    /// The text refers to information about an additional attribute not otherwise specified.
    /// </summary>
    public static InvoiceNoteCode AdditionalAttributeInformation => new() { Value = "ACF" };

    /// <summary>
    /// A declaration on the reason of the absence.
    /// </summary>
    public static InvoiceNoteCode AbsenceDeclaration => new() { Value = "ACG" };

    /// <summary>
    /// A statement on the way a specific variable or set of variables has been aggregated.
    /// </summary>
    public static InvoiceNoteCode AggregationStatement => new() { Value = "ACH" };

    /// <summary>
    /// A statement on the compilation status of an array or other set of figures or calculations.
    /// </summary>
    public static InvoiceNoteCode CompilationStatement => new() { Value = "ACI" };

    /// <summary>
    /// An exception to the agreed definition of a term, concept, formula or other object.
    /// </summary>
    public static InvoiceNoteCode DefinitionalException => new() { Value = "ACJ" };

    /// <summary>
    /// A statement on the privacy or confidential nature of an object.
    /// </summary>
    public static InvoiceNoteCode PrivacyStatement => new() { Value = "ACK" };

    /// <summary>
    /// A statement on the quality of an object.
    /// </summary>
    public static InvoiceNoteCode QualityStatement => new() { Value = "ACL" };

    /// <summary>
    /// The description of a statistical object such as a value list, concept, or structure definition.
    /// </summary>
    public static InvoiceNoteCode StatisticalDescription => new() { Value = "ACM" };

    /// <summary>
    /// The definition of a statistical object such as a value list, concept, or structure definition.
    /// </summary>
    public static InvoiceNoteCode StatisticalDefinition => new() { Value = "ACN" };

    /// <summary>
    /// The name of a statistical object such as a value list, concept or structure definition.
    /// </summary>
    public static InvoiceNoteCode StatisticalName => new() { Value = "ACO" };

    /// <summary>
    /// The title of a statistical object such as a value list, concept, or structure definition.
    /// </summary>
    public static InvoiceNoteCode StatisticalTitle => new() { Value = "ACP" };

    /// <summary>
    /// Information relating to differences between the actual transport dimensions and the normally applicable dimensions.
    /// </summary>
    public static InvoiceNoteCode OffDimensionInformation => new() { Value = "ACQ" };

    /// <summary>
    /// Information relating to unexpected stops during a conveyance.
    /// </summary>
    public static InvoiceNoteCode UnexpectedStopsInformation => new() { Value = "ACR" };

    /// <summary>
    /// Text subject is principles section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static InvoiceNoteCode Principles => new() { Value = "ACS" };

    /// <summary>
    /// Text subject is terms and definition section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static InvoiceNoteCode TermsAndDefinition => new() { Value = "ACT" };

    /// <summary>
    /// Text subject is segment name.
    /// </summary>
    public static InvoiceNoteCode SegmentName => new() { Value = "ACU" };

    /// <summary>
    /// Text subject is name of simple data element.
    /// </summary>
    public static InvoiceNoteCode SimpleDataElementName => new() { Value = "ACV" };

    /// <summary>
    /// Text subject is scope section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static InvoiceNoteCode Scope => new() { Value = "ACW" };

    /// <summary>
    /// Text subject is name of message type.
    /// </summary>
    public static InvoiceNoteCode MessageTypeName => new() { Value = "ACX" };

    /// <summary>
    /// Text subject is introduction section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static InvoiceNoteCode Introduction => new() { Value = "ACY" };

    /// <summary>
    /// Text subject is glossary section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static InvoiceNoteCode Glossary => new() { Value = "ACZ" };

    /// <summary>
    /// Text subject is functional definition section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static InvoiceNoteCode FunctionalDefinition => new() { Value = "ADA" };

    /// <summary>
    /// Text subject is examples as given in the example(s) section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static InvoiceNoteCode Examples => new() { Value = "ADB" };

    /// <summary>
    /// Text subject is cover page of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static InvoiceNoteCode CoverPage => new() { Value = "ADC" };

    /// <summary>
    /// Denotes that the associated text is a dependency (syntax) note.
    /// </summary>
    public static InvoiceNoteCode DependencySyntaxNotes => new() { Value = "ADD" };

    /// <summary>
    /// Text subject is name of code value.
    /// </summary>
    public static InvoiceNoteCode CodeValueName => new() { Value = "ADE" };

    /// <summary>
    /// Text subject is name of code list.
    /// </summary>
    public static InvoiceNoteCode CodeListName => new() { Value = "ADF" };

    /// <summary>
    /// Text subject is an explanation of the intended usage of a segment or segment group.
    /// </summary>
    public static InvoiceNoteCode ClarificationOfUsage => new() { Value = "ADG" };

    /// <summary>
    /// Text subject is name of composite data element.
    /// </summary>
    public static InvoiceNoteCode CompositeDataElementName => new() { Value = "ADH" };

    /// <summary>
    /// Text subject is field of application of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static InvoiceNoteCode FieldOfApplication => new() { Value = "ADI" };

    /// <summary>
    /// Information describing the type of assets and liabilities.
    /// </summary>
    public static InvoiceNoteCode TypeOfAssetsAndLiabilities => new() { Value = "ADJ" };

    /// <summary>
    /// The text contains information about a promotion.
    /// </summary>
    public static InvoiceNoteCode PromotionInformation => new() { Value = "ADK" };

    /// <summary>
    /// Description of the condition of a meter.
    /// </summary>
    public static InvoiceNoteCode MeterCondition => new() { Value = "ADL" };

    /// <summary>
    /// Information related to a particular reading of a meter.
    /// </summary>
    public static InvoiceNoteCode MeterReadingInformation => new() { Value = "ADM" };

    /// <summary>
    /// Information describing the type of the reason of transaction.
    /// </summary>
    public static InvoiceNoteCode TypeOfTransactionReason => new() { Value = "ADN" };

    /// <summary>
    /// Type of survey question.
    /// </summary>
    public static InvoiceNoteCode TypeOfSurveyQuestion => new() { Value = "ADO" };

    /// <summary>
    /// Information for use at the counter of the carrier's agent.
    /// </summary>
    public static InvoiceNoteCode CarrierSAgentCounterInformation => new() { Value = "ADP" };

    /// <summary>
    /// Description or code for the operation to be executed on the equipment.
    /// </summary>
    public static InvoiceNoteCode DescriptionOfWorkItemOnEquipment => new() { Value = "ADQ" };

    /// <summary>
    /// Text subject is message definition.
    /// </summary>
    public static InvoiceNoteCode MessageDefinition => new() { Value = "ADR" };

    /// <summary>
    /// Information pertaining to a booked item.
    /// </summary>
    public static InvoiceNoteCode BookedItemInformation => new() { Value = "ADS" };

    /// <summary>
    /// Text subject is source of document.
    /// </summary>
    public static InvoiceNoteCode SourceOfDocument => new() { Value = "ADT" };

    /// <summary>
    /// Text subject is note.
    /// </summary>
    public static InvoiceNoteCode Note => new() { Value = "ADU" };

    /// <summary>
    /// Text subject is fixed part of segment clarification text.
    /// </summary>
    public static InvoiceNoteCode FixedPartOfSegmentClarificationText => new() { Value = "ADV" };

    /// <summary>
    /// Description of the characteristic of goods in addition to the description of the goods.
    /// </summary>
    public static InvoiceNoteCode CharacteristicsOfGoods => new() { Value = "ADW" };

    /// <summary>
    /// Special discharge instructions concerning the goods.
    /// </summary>
    public static InvoiceNoteCode AdditionalDischargeInstructions => new() { Value = "ADX" };

    /// <summary>
    /// Instructions regarding the stripping of container(s).
    /// </summary>
    public static InvoiceNoteCode ContainerStrippingInstructions => new() { Value = "ADY" };

    /// <summary>
    /// Information on the CSC (Container Safety Convention) plate that is attached to the container.
    /// </summary>
    public static InvoiceNoteCode CSCContainerSafetyConventionPlateInformation => new() { Value = "ADZ" };

    /// <summary>
    /// Additional remarks concerning the cargo.
    /// </summary>
    public static InvoiceNoteCode CargoRemarks => new() { Value = "AEA" };

    /// <summary>
    /// Instruction regarding the temperature control of the cargo.
    /// </summary>
    public static InvoiceNoteCode TemperatureControlInstructions => new() { Value = "AEB" };

    /// <summary>
    /// Remarks refer to data that was expected.
    /// </summary>
    public static InvoiceNoteCode TextRefersToExpectedData => new() { Value = "AEC" };

    /// <summary>
    /// Remarks refer to data that was received.
    /// </summary>
    public static InvoiceNoteCode TextRefersToReceivedData => new() { Value = "AED" };

    /// <summary>
    /// Text subject is section clarification text.
    /// </summary>
    public static InvoiceNoteCode SectionClarificationText => new() { Value = "AEE" };

    /// <summary>
    /// Information given to the beneficiary.
    /// </summary>
    public static InvoiceNoteCode InformationToTheBeneficiary => new() { Value = "AEF" };

    /// <summary>
    /// Information given to the applicant.
    /// </summary>
    public static InvoiceNoteCode InformationToTheApplicant => new() { Value = "AEG" };

    /// <summary>
    /// Instructions made to the beneficiary.
    /// </summary>
    public static InvoiceNoteCode InstructionsToTheBeneficiary => new() { Value = "AEH" };

    /// <summary>
    /// Instructions given to the applicant.
    /// </summary>
    public static InvoiceNoteCode InstructionsToTheApplicant => new() { Value = "AEI" };

    /// <summary>
    /// Information about the controlled atmosphere.
    /// </summary>
    public static InvoiceNoteCode ControlledAtmosphere => new() { Value = "AEJ" };

    /// <summary>
    /// Additional information in plain text to support a take off annotation. Taking off is the process of assessing the quantity work from extracting the measurement from construction documentation.
    /// </summary>
    public static InvoiceNoteCode TakeOffAnnotation => new() { Value = "AEK" };

    /// <summary>
    /// Additional information in plain language to support a price variation.
    /// </summary>
    public static InvoiceNoteCode PriceVariationNarrative => new() { Value = "AEL" };

    /// <summary>
    /// Documentary credit amendment instructions.
    /// </summary>
    public static InvoiceNoteCode DocumentaryCreditAmendmentInstructions => new() { Value = "AEM" };

    /// <summary>
    /// Additional information in plain language to support a standard method.
    /// </summary>
    public static InvoiceNoteCode StandardMethodNarrative => new() { Value = "AEN" };

    /// <summary>
    /// Additional information in plain language to support the project.
    /// </summary>
    public static InvoiceNoteCode ProjectNarrative => new() { Value = "AEO" };

    /// <summary>
    /// Additional information related to radioactive goods.
    /// </summary>
    public static InvoiceNoteCode RadioactiveGoodsAdditionalInformation => new() { Value = "AEP" };

    /// <summary>
    /// Information given from one bank to another.
    /// </summary>
    public static InvoiceNoteCode BankToBankInformation => new() { Value = "AEQ" };

    /// <summary>
    /// Instructions given for reimbursement purposes.
    /// </summary>
    public static InvoiceNoteCode ReimbursementInstructions => new() { Value = "AER" };

    /// <summary>
    /// Identification of the reason for amending a message.
    /// </summary>
    public static InvoiceNoteCode ReasonForAmendingAMessage => new() { Value = "AES" };

    /// <summary>
    /// Instructions to the paying and/or accepting and/or negotiating bank.
    /// </summary>
    public static InvoiceNoteCode InstructionsToThePayingAndOrAcceptingAndOrNegotiatingBank => new() { Value = "AET" };

    /// <summary>
    /// Instructions given about the interest.
    /// </summary>
    public static InvoiceNoteCode InterestInstructions => new() { Value = "AEU" };

    /// <summary>
    /// Instructions about agent commission.
    /// </summary>
    public static InvoiceNoteCode AgentCommission => new() { Value = "AEV" };

    /// <summary>
    /// Instructions to the remitting bank.
    /// </summary>
    public static InvoiceNoteCode RemittingBankInstructions => new() { Value = "AEW" };

    /// <summary>
    /// Instructions to the bank, other than the remitting bank, involved in processing the collection.
    /// </summary>
    public static InvoiceNoteCode InstructionsToTheCollectingBank => new() { Value = "AEX" };

    /// <summary>
    /// Instructions about the collection amount.
    /// </summary>
    public static InvoiceNoteCode CollectionAmountInstructions => new() { Value = "AEY" };

    /// <summary>
    /// Text relating to internal auditing information.
    /// </summary>
    public static InvoiceNoteCode InternalAuditingInformation => new() { Value = "AEZ" };

    /// <summary>
    /// Denotes that the associated text is a constraint.
    /// </summary>
    public static InvoiceNoteCode Constraint => new() { Value = "AFA" };

    /// <summary>
    /// Denotes that the associated text is a comment.
    /// </summary>
    public static InvoiceNoteCode Comment => new() { Value = "AFB" };

    /// <summary>
    /// Denotes that the associated text is a semantic note.
    /// </summary>
    public static InvoiceNoteCode SemanticNote => new() { Value = "AFC" };

    /// <summary>
    /// Denotes that the associated text is an item of help text.
    /// </summary>
    public static InvoiceNoteCode HelpText => new() { Value = "AFD" };

    /// <summary>
    /// Denotes that the associated text is a legend.
    /// </summary>
    public static InvoiceNoteCode Legend => new() { Value = "AFE" };

    /// <summary>
    /// A description of the structure of a batch code.
    /// </summary>
    public static InvoiceNoteCode BatchCodeStructure => new() { Value = "AFF" };

    /// <summary>
    /// A general description of the application of a product.
    /// </summary>
    public static InvoiceNoteCode ProductApplication => new() { Value = "AFG" };

    /// <summary>
    /// Complaint of customer.
    /// </summary>
    public static InvoiceNoteCode CustomerComplaint => new() { Value = "AFH" };

    /// <summary>
    /// The probable cause of fault.
    /// </summary>
    public static InvoiceNoteCode ProbableCauseOfFault => new() { Value = "AFI" };

    /// <summary>
    /// Description of the defect.
    /// </summary>
    public static InvoiceNoteCode DefectDescription => new() { Value = "AFJ" };

    /// <summary>
    /// The description of the work performed during the repair.
    /// </summary>
    public static InvoiceNoteCode RepairDescription => new() { Value = "AFK" };

    /// <summary>
    /// Comments relevant to a review.
    /// </summary>
    public static InvoiceNoteCode ReviewComments => new() { Value = "AFL" };

    /// <summary>
    /// Denotes that the associated text is a title.
    /// </summary>
    public static InvoiceNoteCode Title => new() { Value = "AFM" };

    /// <summary>
    /// An amount description in clear text.
    /// </summary>
    public static InvoiceNoteCode DescriptionOfAmount => new() { Value = "AFN" };

    /// <summary>
    /// Information describing the responsibilities.
    /// </summary>
    public static InvoiceNoteCode Responsibilities => new() { Value = "AFO" };

    /// <summary>
    /// Information concerning suppliers.
    /// </summary>
    public static InvoiceNoteCode Supplier => new() { Value = "AFP" };

    /// <summary>
    /// Information concerning the region(s) where purchases are made.
    /// </summary>
    public static InvoiceNoteCode PurchaseRegion => new() { Value = "AFQ" };

    /// <summary>
    /// Information concerning an association of one party with another party(ies).
    /// </summary>
    public static InvoiceNoteCode Affiliation => new() { Value = "AFR" };

    /// <summary>
    /// Information concerning the borrower.
    /// </summary>
    public static InvoiceNoteCode Borrower => new() { Value = "AFS" };

    /// <summary>
    /// Information concerning an entity's line of business.
    /// </summary>
    public static InvoiceNoteCode LineOfBusiness => new() { Value = "AFT" };

    /// <summary>
    /// Description of financial institution(s) used by an entity.
    /// </summary>
    public static InvoiceNoteCode FinancialInstitution => new() { Value = "AFU" };

    /// <summary>
    /// Information about the business founder.
    /// </summary>
    public static InvoiceNoteCode BusinessFounder => new() { Value = "AFV" };

    /// <summary>
    /// Description of the business history.
    /// </summary>
    public static InvoiceNoteCode BusinessHistory => new() { Value = "AFW" };

    /// <summary>
    /// Information concerning the general banking arrangements.
    /// </summary>
    public static InvoiceNoteCode BankingArrangements => new() { Value = "AFX" };

    /// <summary>
    /// Description of the business origin.
    /// </summary>
    public static InvoiceNoteCode BusinessOrigin => new() { Value = "AFY" };

    /// <summary>
    /// Description of the entity's brands.
    /// </summary>
    public static InvoiceNoteCode BrandNamesDescription => new() { Value = "AFZ" };

    /// <summary>
    /// Details about the financing of the business.
    /// </summary>
    public static InvoiceNoteCode BusinessFinancingDetails => new() { Value = "AGA" };

    /// <summary>
    /// Information concerning an entity's competition.
    /// </summary>
    public static InvoiceNoteCode Competition => new() { Value = "AGB" };

    /// <summary>
    /// Details about the construction process.
    /// </summary>
    public static InvoiceNoteCode ConstructionProcessDetails => new() { Value = "AGC" };

    /// <summary>
    /// Information concerning the line of business of a construction entity.
    /// </summary>
    public static InvoiceNoteCode ConstructionSpecialty => new() { Value = "AGD" };

    /// <summary>
    /// Details about contract(s).
    /// </summary>
    public static InvoiceNoteCode ContractInformation => new() { Value = "AGE" };

    /// <summary>
    /// Details about a corporate filing.
    /// </summary>
    public static InvoiceNoteCode CorporateFiling => new() { Value = "AGF" };

    /// <summary>
    /// Description of customers.
    /// </summary>
    public static InvoiceNoteCode CustomerInformation => new() { Value = "AGG" };

    /// <summary>
    /// Information concerning the copyright notice.
    /// </summary>
    public static InvoiceNoteCode CopyrightNotice => new() { Value = "AGH" };

    /// <summary>
    /// Details about the contingent debt.
    /// </summary>
    public static InvoiceNoteCode ContingentDebt => new() { Value = "AGI" };

    /// <summary>
    /// Details about the law or penal codes that resulted in conviction.
    /// </summary>
    public static InvoiceNoteCode ConvictionDetails => new() { Value = "AGJ" };

    /// <summary>
    /// Description of equipment.
    /// </summary>
    public static InvoiceNoteCode Equipment => new() { Value = "AGK" };

    /// <summary>
    /// Comments about the workforce.
    /// </summary>
    public static InvoiceNoteCode WorkforceDescription => new() { Value = "AGL" };

    /// <summary>
    /// Description about exemptions.
    /// </summary>
    public static InvoiceNoteCode Exemption => new() { Value = "AGM" };

    /// <summary>
    /// Information on future plans.
    /// </summary>
    public static InvoiceNoteCode FuturePlans => new() { Value = "AGN" };

    /// <summary>
    /// Information concerning the interviewee conversation.
    /// </summary>
    public static InvoiceNoteCode IntervieweeConversationInformation => new() { Value = "AGO" };

    /// <summary>
    /// Description of intangible asset(s).
    /// </summary>
    public static InvoiceNoteCode IntangibleAsset => new() { Value = "AGP" };

    /// <summary>
    /// Description of the inventory.
    /// </summary>
    public static InvoiceNoteCode Inventory => new() { Value = "AGQ" };

    /// <summary>
    /// Description of the investments.
    /// </summary>
    public static InvoiceNoteCode Investment => new() { Value = "AGR" };

    /// <summary>
    /// Description of the intercompany relations.
    /// </summary>
    public static InvoiceNoteCode IntercompanyRelationsInformation => new() { Value = "AGS" };

    /// <summary>
    /// Description of the joint venture.
    /// </summary>
    public static InvoiceNoteCode JointVenture => new() { Value = "AGT" };

    /// <summary>
    /// Description of a loan.
    /// </summary>
    public static InvoiceNoteCode Loan => new() { Value = "AGU" };

    /// <summary>
    /// Description of the long term debt.
    /// </summary>
    public static InvoiceNoteCode LongTermDebt => new() { Value = "AGV" };

    /// <summary>
    /// Description of a location.
    /// </summary>
    public static InvoiceNoteCode Location => new() { Value = "AGW" };

    /// <summary>
    /// Details on the current legal structure.
    /// </summary>
    public static InvoiceNoteCode CurrentLegalStructure => new() { Value = "AGX" };

    /// <summary>
    /// Details on a marital contract.
    /// </summary>
    public static InvoiceNoteCode MaritalContract => new() { Value = "AGY" };

    /// <summary>
    /// Information concerning marketing activities.
    /// </summary>
    public static InvoiceNoteCode MarketingActivities => new() { Value = "AGZ" };

    /// <summary>
    /// Description of a merger.
    /// </summary>
    public static InvoiceNoteCode Merger => new() { Value = "AHA" };

    /// <summary>
    /// Description of the marketable securities.
    /// </summary>
    public static InvoiceNoteCode MarketableSecurities => new() { Value = "AHB" };

    /// <summary>
    /// Description of the business debt(s).
    /// </summary>
    public static InvoiceNoteCode BusinessDebt => new() { Value = "AHC" };

    /// <summary>
    /// Information concerning the original legal structure.
    /// </summary>
    public static InvoiceNoteCode OriginalLegalStructure => new() { Value = "AHD" };

    /// <summary>
    /// Information describing how a company uses employees from another company.
    /// </summary>
    public static InvoiceNoteCode EmployeeSharingArrangements => new() { Value = "AHE" };

    /// <summary>
    /// Description about the organization of a company.
    /// </summary>
    public static InvoiceNoteCode OrganizationDetails => new() { Value = "AHF" };

    /// <summary>
    /// Information concerning public records.
    /// </summary>
    public static InvoiceNoteCode PublicRecordDetails => new() { Value = "AHG" };

    /// <summary>
    /// Information concerning the price range of products made or sold.
    /// </summary>
    public static InvoiceNoteCode PriceRange => new() { Value = "AHH" };

    /// <summary>
    /// Information on the accomplishments fitting a party for a position.
    /// </summary>
    public static InvoiceNoteCode Qualifications => new() { Value = "AHI" };

    /// <summary>
    /// Information concerning the registered activity.
    /// </summary>
    public static InvoiceNoteCode RegisteredActivity => new() { Value = "AHJ" };

    /// <summary>
    /// Description of the sentence imposed in a criminal proceeding.
    /// </summary>
    public static InvoiceNoteCode CriminalSentence => new() { Value = "AHK" };

    /// <summary>
    /// Description of the selling means.
    /// </summary>
    public static InvoiceNoteCode SalesMethod => new() { Value = "AHL" };

    /// <summary>
    /// Free form description relating to the school(s) attended.
    /// </summary>
    public static InvoiceNoteCode EducationalInstitutionInformation => new() { Value = "AHM" };

    /// <summary>
    /// Describes the status details.
    /// </summary>
    public static InvoiceNoteCode StatusDetails => new() { Value = "AHN" };

    /// <summary>
    /// Description of the sales.
    /// </summary>
    public static InvoiceNoteCode Sales => new() { Value = "AHO" };

    /// <summary>
    /// Information about the spouse.
    /// </summary>
    public static InvoiceNoteCode SpouseInformation => new() { Value = "AHP" };

    /// <summary>
    /// Details about the educational degree received from a school.
    /// </summary>
    public static InvoiceNoteCode EducationalDegreeInformation => new() { Value = "AHQ" };

    /// <summary>
    /// General description of shareholding.
    /// </summary>
    public static InvoiceNoteCode ShareholdingInformation => new() { Value = "AHR" };

    /// <summary>
    /// Information on the sales territory.
    /// </summary>
    public static InvoiceNoteCode SalesTerritory => new() { Value = "AHS" };

    /// <summary>
    /// Comments made by an accountant regarding a financial statement.
    /// </summary>
    public static InvoiceNoteCode AccountantSComments => new() { Value = "AHT" };

    /// <summary>
    /// Description of the exemption provided to a location by a law.
    /// </summary>
    public static InvoiceNoteCode ExemptionLawLocation => new() { Value = "AHU" };

    /// <summary>
    /// Information about the classes or categories of shares.
    /// </summary>
    public static InvoiceNoteCode ShareClassifications => new() { Value = "AHV" };

    /// <summary>
    /// Description of a prediction.
    /// </summary>
    public static InvoiceNoteCode Forecast => new() { Value = "AHW" };

    /// <summary>
    /// Description of the location of an event.
    /// </summary>
    public static InvoiceNoteCode EventLocation => new() { Value = "AHX" };

    /// <summary>
    /// Information related to occupancy of a facility.
    /// </summary>
    public static InvoiceNoteCode FacilityOccupancy => new() { Value = "AHY" };

    /// <summary>
    /// Specific information provided about the importation and exportation of goods.
    /// </summary>
    public static InvoiceNoteCode ImportAndExportDetails => new() { Value = "AHZ" };

    /// <summary>
    /// Additional information about a facility.
    /// </summary>
    public static InvoiceNoteCode AdditionalFacilityInformation => new() { Value = "AIA" };

    /// <summary>
    /// Description of the value of inventory.
    /// </summary>
    public static InvoiceNoteCode InventoryValue => new() { Value = "AIB" };

    /// <summary>
    /// Description of the education of a person.
    /// </summary>
    public static InvoiceNoteCode Education => new() { Value = "AIC" };

    /// <summary>
    /// Description of a thing that happens or takes place.
    /// </summary>
    public static InvoiceNoteCode Event => new() { Value = "AID" };

    /// <summary>
    /// Information about agents the entity uses.
    /// </summary>
    public static InvoiceNoteCode Agent => new() { Value = "AIE" };

    /// <summary>
    /// Details of domestically agreed financial statement.
    /// </summary>
    public static InvoiceNoteCode DomesticallyAgreedFinancialStatementDetails => new() { Value = "AIF" };

    /// <summary>
    /// Description of other current asset.
    /// </summary>
    public static InvoiceNoteCode OtherCurrentAssetDescription => new() { Value = "AIG" };

    /// <summary>
    /// Description of other current liability.
    /// </summary>
    public static InvoiceNoteCode OtherCurrentLiabilityDescription => new() { Value = "AIH" };

    /// <summary>
    /// Description of the former line of business.
    /// </summary>
    public static InvoiceNoteCode FormerBusinessActivity => new() { Value = "AII" };

    /// <summary>
    /// Description of how a trading name is used.
    /// </summary>
    public static InvoiceNoteCode TradeNameUse => new() { Value = "AIJ" };

    /// <summary>
    /// Description of the authorized signatory.
    /// </summary>
    public static InvoiceNoteCode SigningAuthority => new() { Value = "AIK" };

    /// <summary>
    /// [4376] Description of guarantee.
    /// </summary>
    public static InvoiceNoteCode Guarantee => new() { Value = "AIL" };

    /// <summary>
    /// Description of the operation of a holding company.
    /// </summary>
    public static InvoiceNoteCode HoldingCompanyOperation => new() { Value = "AIM" };

    /// <summary>
    /// Information on routing of the consignment.
    /// </summary>
    public static InvoiceNoteCode ConsignmentRouting => new() { Value = "AIN" };

    /// <summary>
    /// A letter citing any condition in dispute.
    /// </summary>
    public static InvoiceNoteCode LetterOfProtest => new() { Value = "AIO" };

    /// <summary>
    /// A free text question.
    /// </summary>
    public static InvoiceNoteCode Question => new() { Value = "AIP" };

    /// <summary>
    /// Free text information related to a party.
    /// </summary>
    public static InvoiceNoteCode PartyInformation => new() { Value = "AIQ" };

    /// <summary>
    /// Description of the boundaries of a geographical area.
    /// </summary>
    public static InvoiceNoteCode AreaBoundariesDescription => new() { Value = "AIR" };

    /// <summary>
    /// The free text contains advertisement information.
    /// </summary>
    public static InvoiceNoteCode AdvertisementInformation => new() { Value = "AIS" };

    /// <summary>
    /// Details regarding the financial statement in free text.
    /// </summary>
    public static InvoiceNoteCode FinancialStatementDetails => new() { Value = "AIT" };

    /// <summary>
    /// Description of how to access an entity.
    /// </summary>
    public static InvoiceNoteCode AccessInstructions => new() { Value = "AIU" };

    /// <summary>
    /// Description of an entity's liquidity.
    /// </summary>
    public static InvoiceNoteCode Liquidity => new() { Value = "AIV" };

    /// <summary>
    /// Description of the line of credit available to an entity.
    /// </summary>
    public static InvoiceNoteCode CreditLine => new() { Value = "AIW" };

    /// <summary>
    /// Text describing the terms of warranty which apply to a product or service.
    /// </summary>
    public static InvoiceNoteCode WarrantyTerms => new() { Value = "AIX" };

    /// <summary>
    /// Plain language description of a division of an entity.
    /// </summary>
    public static InvoiceNoteCode DivisionDescription => new() { Value = "AIY" };

    /// <summary>
    /// Instruction on how to report.
    /// </summary>
    public static InvoiceNoteCode ReportingInstruction => new() { Value = "AIZ" };

    /// <summary>
    /// The result of an examination.
    /// </summary>
    public static InvoiceNoteCode ExaminationResult => new() { Value = "AJA" };

    /// <summary>
    /// The result of a laboratory investigation.
    /// </summary>
    public static InvoiceNoteCode LaboratoryResult => new() { Value = "AJB" };

    /// <summary>
    /// Information referring to allowance/charge.
    /// </summary>
    public static InvoiceNoteCode AllowanceChargeInformation => new() { Value = "ALC" };

    /// <summary>
    /// The result of an X-ray examination.
    /// </summary>
    public static InvoiceNoteCode XRayResult => new() { Value = "ALD" };

    /// <summary>
    /// The result of a pathology investigation.
    /// </summary>
    public static InvoiceNoteCode PathologyResult => new() { Value = "ALE" };

    /// <summary>
    /// Details of an intervention.
    /// </summary>
    public static InvoiceNoteCode InterventionDescription => new() { Value = "ALF" };

    /// <summary>
    /// Summary description of admittance.
    /// </summary>
    public static InvoiceNoteCode SummaryOfAdmittance => new() { Value = "ALG" };

    /// <summary>
    /// Details of a course of medical treatment.
    /// </summary>
    public static InvoiceNoteCode MedicalTreatmentCourseDetail => new() { Value = "ALH" };

    /// <summary>
    /// Details of a prognosis.
    /// </summary>
    public static InvoiceNoteCode Prognosis => new() { Value = "ALI" };

    /// <summary>
    /// Instruction given to a patient.
    /// </summary>
    public static InvoiceNoteCode InstructionToPatient => new() { Value = "ALJ" };

    /// <summary>
    /// Instruction given to a physician.
    /// </summary>
    public static InvoiceNoteCode InstructionToPhysician => new() { Value = "ALK" };

    /// <summary>
    /// The note implies to all documents.
    /// </summary>
    public static InvoiceNoteCode AllDocuments => new() { Value = "ALL" };

    /// <summary>
    /// Details of medicine treatment.
    /// </summary>
    public static InvoiceNoteCode MedicineTreatment => new() { Value = "ALM" };

    /// <summary>
    /// Details of medicine dosage and method of administration.
    /// </summary>
    public static InvoiceNoteCode MedicineDosageAndAdministration => new() { Value = "ALN" };

    /// <summary>
    /// Details of when and/or where the patient is available.
    /// </summary>
    public static InvoiceNoteCode AvailabilityOfPatient => new() { Value = "ALO" };

    /// <summary>
    /// Details of the reason for a requested service.
    /// </summary>
    public static InvoiceNoteCode ReasonForServiceRequest => new() { Value = "ALP" };

    /// <summary>
    /// Details of the purpose of a service.
    /// </summary>
    public static InvoiceNoteCode PurposeOfService => new() { Value = "ALQ" };

    /// <summary>
    /// Conditions under which arrival takes place.
    /// </summary>
    public static InvoiceNoteCode ArrivalConditions => new() { Value = "ARR" };

    /// <summary>
    /// Comment by the requester of a service.
    /// </summary>
    public static InvoiceNoteCode ServiceRequesterSComment => new() { Value = "ARS" };

    /// <summary>
    /// (4130) (4136) (4426) Name, code, password etc. given for authentication purposes.
    /// </summary>
    public static InvoiceNoteCode Authentication => new() { Value = "AUT" };

    /// <summary>
    /// The description of the location requested.
    /// </summary>
    public static InvoiceNoteCode RequestedLocationDescription => new() { Value = "AUU" };

    /// <summary>
    /// The event or condition that initiates the administration of a single dose of medicine or a period of treatment.
    /// </summary>
    public static InvoiceNoteCode MedicineAdministrationCondition => new() { Value = "AUV" };

    /// <summary>
    /// Information concerning a patient.
    /// </summary>
    public static InvoiceNoteCode PatientInformation => new() { Value = "AUW" };

    /// <summary>
    /// Action to be taken to avert possible harmful affects.
    /// </summary>
    public static InvoiceNoteCode PrecautionaryMeasure => new() { Value = "AUX" };

    /// <summary>
    /// Free text description is related to a service characteristic.
    /// </summary>
    public static InvoiceNoteCode ServiceCharacteristic => new() { Value = "AUY" };

    /// <summary>
    /// Comment about an event that is planned.
    /// </summary>
    public static InvoiceNoteCode PlannedEventComment => new() { Value = "AUZ" };

    /// <summary>
    /// Comment about the expected delay.
    /// </summary>
    public static InvoiceNoteCode ExpectedDelayComment => new() { Value = "AVA" };

    /// <summary>
    /// Comment about the requirements for transport.
    /// </summary>
    public static InvoiceNoteCode TransportRequirementsComment => new() { Value = "AVB" };

    /// <summary>
    /// The condition under which the approval is considered.
    /// </summary>
    public static InvoiceNoteCode TemporaryApprovalCondition => new() { Value = "AVC" };

    /// <summary>
    /// Information provided in this category will be used by the trader to make certain declarations in relation to Customs Valuation.
    /// </summary>
    public static InvoiceNoteCode CustomsValuationInformation => new() { Value = "AVD" };

    /// <summary>
    /// Description of the VAT margin scheme applied.
    /// </summary>
    public static InvoiceNoteCode ValueAddedTaxVATMarginScheme => new() { Value = "AVE" };

    /// <summary>
    /// Information about Maritime Declaration of Health.
    /// </summary>
    public static InvoiceNoteCode MaritimeDeclarationOfHealthAVF => new() { Value = "AVF" };

    /// <summary>
    /// Information related to baggage tendered by a passenger, such as odd size indication, tag.
    /// </summary>
    public static InvoiceNoteCode PassengerBaggageInformation => new() { Value = "BAG" };

    /// <summary>
    /// Information about Maritime Declaration of Health.
    /// </summary>
    public static InvoiceNoteCode MaritimeDeclarationOfHealthBAH => new() { Value = "BAH" };

    /// <summary>
    /// Address at which additional information on the product can be found.
    /// </summary>
    public static InvoiceNoteCode AdditionalProductInformationAddress => new() { Value = "BAI" };

    /// <summary>
    /// Specification of free text information which is to be printed on a despatch advice.
    /// </summary>
    public static InvoiceNoteCode InformationToBePrintedOnDespatchAdvice => new() { Value = "BAJ" };

    /// <summary>
    /// Remarks concerning missing goods.
    /// </summary>
    public static InvoiceNoteCode MissingGoodsRemarks => new() { Value = "BAK" };

    /// <summary>
    /// Information related to the non-acceptance of an order, goods or a consignment.
    /// </summary>
    public static InvoiceNoteCode NonAcceptanceInformation => new() { Value = "BAL" };

    /// <summary>
    /// Information related to the return of items.
    /// </summary>
    public static InvoiceNoteCode ReturnsInformation => new() { Value = "BAM" };

    /// <summary>
    /// Note contains information related to sub-line item data.
    /// </summary>
    public static InvoiceNoteCode SubLineItemInformation => new() { Value = "BAN" };

    /// <summary>
    /// Information related to a test.
    /// </summary>
    public static InvoiceNoteCode TestInformation => new() { Value = "BAO" };

    /// <summary>
    /// The external link to a digital document (e.g.: URL).
    /// </summary>
    public static InvoiceNoteCode ExternalLink => new() { Value = "BAP" };

    /// <summary>
    /// Reason for Value Added Tax (VAT) exemption.
    /// </summary>
    public static InvoiceNoteCode VATExemptionReason => new() { Value = "BAQ" };

    /// <summary>
    /// [4180] Clause on a transport document regarding the cargo being consigned. Synonym: Bill of Lading clause.
    /// </summary>
    public static InvoiceNoteCode TransportContractDocumentClause => new() { Value = "BLC" };

    /// <summary>
    /// Instruction with the purpose of preparing the patient.
    /// </summary>
    public static InvoiceNoteCode InstructionToPrepareThePatient => new() { Value = "BLD" };

    /// <summary>
    /// Comment about treatment with medicine.
    /// </summary>
    public static InvoiceNoteCode MedicineTreatmentComment => new() { Value = "BLE" };

    /// <summary>
    /// Comment about the result of an examination.
    /// </summary>
    public static InvoiceNoteCode ExaminationResultComment => new() { Value = "BLF" };

    /// <summary>
    /// Comment about the requested service.
    /// </summary>
    public static InvoiceNoteCode ServiceRequestComment => new() { Value = "BLG" };

    /// <summary>
    /// Details of the reason for a prescription.
    /// </summary>
    public static InvoiceNoteCode PrescriptionReason => new() { Value = "BLH" };

    /// <summary>
    /// Comment concerning a specified prescription.
    /// </summary>
    public static InvoiceNoteCode PrescriptionComment => new() { Value = "BLI" };

    /// <summary>
    /// Comment concerning a clinical investigation.
    /// </summary>
    public static InvoiceNoteCode ClinicalInvestigationComment => new() { Value = "BLJ" };

    /// <summary>
    /// Comment concerning the specification of a medicinal product.
    /// </summary>
    public static InvoiceNoteCode MedicinalSpecificationComment => new() { Value = "BLK" };

    /// <summary>
    /// Comment concerning economic contribution.
    /// </summary>
    public static InvoiceNoteCode EconomicContributionComment => new() { Value = "BLL" };

    /// <summary>
    /// Comment about the status of a plan.
    /// </summary>
    public static InvoiceNoteCode StatusOfAPlan => new() { Value = "BLM" };

    /// <summary>
    /// Information regarding a random sample test.
    /// </summary>
    public static InvoiceNoteCode RandomSampleTestInformation => new() { Value = "BLN" };

    /// <summary>
    /// Text subject is a period of time.
    /// </summary>
    public static InvoiceNoteCode PeriodOfTime => new() { Value = "BLO" };

    /// <summary>
    /// Information about legislation.
    /// </summary>
    public static InvoiceNoteCode Legislation => new() { Value = "BLP" };

    /// <summary>
    /// Text describing security measures that are requested to be executed (e.g. access controls, supervision of ship's stores).
    /// </summary>
    public static InvoiceNoteCode SecurityMeasuresRequested => new() { Value = "BLQ" };

    /// <summary>
    /// [4244] Remarks concerning the complete consignment to be printed on the transport document. Synonym: Bill of Lading remark.
    /// </summary>
    public static InvoiceNoteCode TransportContractDocumentRemark => new() { Value = "BLR" };

    /// <summary>
    /// Text describing the security information as applicable at the port facility in the previous port where a ship/port interface was conducted.
    /// </summary>
    public static InvoiceNoteCode PreviousPortOfCallSecurityInformation => new() { Value = "BLS" };

    /// <summary>
    /// Text describing security related information (e.g security measures currently in force on a vessel).
    /// </summary>
    public static InvoiceNoteCode SecurityInformation => new() { Value = "BLT" };

    /// <summary>
    /// Text describing waste related information.
    /// </summary>
    public static InvoiceNoteCode WasteInformation => new() { Value = "BLU" };

    /// <summary>
    /// Consumer marketing information, short description.
    /// </summary>
    public static InvoiceNoteCode B2CMarketingInformationShortDescription => new() { Value = "BLV" };

    /// <summary>
    /// Trading partner marketing information, long description.
    /// </summary>
    public static InvoiceNoteCode B2BMarketingInformationLongDescription => new() { Value = "BLW" };

    /// <summary>
    /// Consumer marketing information, long description.
    /// </summary>
    public static InvoiceNoteCode B2CMarketingInformationLongDescription => new() { Value = "BLX" };

    /// <summary>
    /// Information on the ingredient make up of the product.
    /// </summary>
    public static InvoiceNoteCode ProductIngredients => new() { Value = "BLY" };

    /// <summary>
    /// Short name of a location e.g. for display or printing purposes.
    /// </summary>
    public static InvoiceNoteCode LocationShortName => new() { Value = "BLZ" };

    /// <summary>
    /// The text contains a description of the material used for packaging.
    /// </summary>
    public static InvoiceNoteCode PackagingMaterialInformation => new() { Value = "BMA" };

    /// <summary>
    /// Text contains information on the material used for stuffing.
    /// </summary>
    public static InvoiceNoteCode FillerMaterialInformation => new() { Value = "BMB" };

    /// <summary>
    /// Text contains information on ship-to-ship activities.
    /// </summary>
    public static InvoiceNoteCode ShipToShipActivityInformation => new() { Value = "BMC" };

    /// <summary>
    /// A description of the type of material for packaging beyond the level covered by standards such as UN Recommendation 21.
    /// </summary>
    public static InvoiceNoteCode PackageMaterialDescription => new() { Value = "BMD" };

    /// <summary>
    /// Textual representation of the markings on a consumer level package.
    /// </summary>
    public static InvoiceNoteCode ConsumerLevelPackageMarking => new() { Value = "BME" };

    /// <summary>
    /// Any coded or clear instruction agreed by customer and carrier regarding the declaration of the goods.
    /// </summary>
    public static InvoiceNoteCode CustomsClearanceInstructions => new() { Value = "CCI" };

    /// <summary>
    /// Any coded or clear instruction agreed by customer and carrier regarding the export declaration of the goods.
    /// </summary>
    public static InvoiceNoteCode CustomsClearanceInstructionsExport => new() { Value = "CEX" };

    /// <summary>
    /// Note contains change information.
    /// </summary>
    public static InvoiceNoteCode ChangeInformation => new() { Value = "CHG" };

    /// <summary>
    /// Any coded or clear instruction agreed by customer and carrier regarding the import declaration of the goods.
    /// </summary>
    public static InvoiceNoteCode CustomsClearanceInstructionImport => new() { Value = "CIP" };

    /// <summary>
    /// Name of the place where Customs clearance is asked to be executed as requested by the consignee/consignor.
    /// </summary>
    public static InvoiceNoteCode ClearancePlaceRequested => new() { Value = "CLP" };

    /// <summary>
    /// Instructions concerning the loading of the container.
    /// </summary>
    public static InvoiceNoteCode LoadingRemarks => new() { Value = "CLR" };

    /// <summary>
    /// Additional information related to an order.
    /// </summary>
    public static InvoiceNoteCode OrderInformation => new() { Value = "COI" };

    /// <summary>
    /// Remarks from or for a supplier of goods or services.
    /// </summary>
    public static InvoiceNoteCode CustomerRemarks => new() { Value = "CUR" };

    /// <summary>
    /// (4034) Note contains customs declaration information.
    /// </summary>
    public static InvoiceNoteCode CustomsDeclarationInformation => new() { Value = "CUS" };

    /// <summary>
    /// Remarks concerning damage on the cargo.
    /// </summary>
    public static InvoiceNoteCode DamageRemarks => new() { Value = "DAR" };

    /// <summary>
    /// [4020] Text of a declaration made by the issuer of a document.
    /// </summary>
    public static InvoiceNoteCode DocumentIssuerDeclaration => new() { Value = "DCL" };

    /// <summary>
    /// Information about delivery.
    /// </summary>
    public static InvoiceNoteCode DeliveryInformation => new() { Value = "DEL" };

    /// <summary>
    /// [4492] Instructions regarding the delivery of the cargo.
    /// </summary>
    public static InvoiceNoteCode DeliveryInstructions => new() { Value = "DIN" };

    /// <summary>
    /// Instructions pertaining to the documentation.
    /// </summary>
    public static InvoiceNoteCode DocumentationInstructions => new() { Value = "DOC" };

    /// <summary>
    /// The text contains a statement constituting a duty declaration.
    /// </summary>
    public static InvoiceNoteCode DutyDeclaration => new() { Value = "DUT" };

    /// <summary>
    /// Physical route effectively used for the movement of the means of transport.
    /// </summary>
    public static InvoiceNoteCode EffectiveUsedRouting => new() { Value = "EUR" };

    /// <summary>
    /// The first block of text to be printed on the transport contract.
    /// </summary>
    public static InvoiceNoteCode FirstBlockToBePrintedOnTheTransportContract => new() { Value = "FBC" };

    /// <summary>
    /// Free text information on a transport document to indicate payment information by Government Bill of Lading.
    /// </summary>
    public static InvoiceNoteCode GovernmentBillOfLadingInformation => new() { Value = "GBL" };

    /// <summary>
    /// Note is general in nature, applies to entire transaction segment.
    /// </summary>
    public static InvoiceNoteCode EntireTransactionSet => new() { Value = "GEN" };

    /// <summary>
    /// Special permission for road transport of certain goods in the German dangerous goods regulation for road transport.
    /// </summary>
    public static InvoiceNoteCode FurtherInformationConcerningGGVSPar7 => new() { Value = "GS7" };

    /// <summary>
    /// [4078] Free form description of a set of handling instructions. For example how specified goods, packages or transport equipment (container) should be handled.
    /// </summary>
    public static InvoiceNoteCode ConsignmentHandlingInstruction => new() { Value = "HAN" };

    /// <summary>
    /// Information pertaining to a hazard.
    /// </summary>
    public static InvoiceNoteCode HazardInformation => new() { Value = "HAZ" };

    /// <summary>
    /// [4070] Any remarks given for the information of the consignee.
    /// </summary>
    public static InvoiceNoteCode ConsignmentInformationForConsignee => new() { Value = "ICN" };

    /// <summary>
    /// (4112) Instructions regarding the cargo insurance.
    /// </summary>
    public static InvoiceNoteCode InsuranceInstructions => new() { Value = "IIN" };

    /// <summary>
    /// Instructions as to which freight and charges components have to be mailed to whom.
    /// </summary>
    public static InvoiceNoteCode InvoiceMailingInstructions => new() { Value = "IMI" };

    /// <summary>
    /// Free text describing goods on a commercial invoice line.
    /// </summary>
    public static InvoiceNoteCode CommercialInvoiceItemDescription => new() { Value = "IND" };

    /// <summary>
    /// Specific note contains insurance information.
    /// </summary>
    public static InvoiceNoteCode InsuranceInformation => new() { Value = "INS" };

    /// <summary>
    /// Note contains invoice instructions.
    /// </summary>
    public static InvoiceNoteCode InvoiceInstruction => new() { Value = "INV" };

    /// <summary>
    /// Data entered by railway stations when required, e.g. specified trains, additional sheets for freight calculations, special measures, etc.
    /// </summary>
    public static InvoiceNoteCode InformationForRailwayPurpose => new() { Value = "IRP" };

    /// <summary>
    /// Information concerning the pre-carriage to the port of discharge if by other means than a vessel.
    /// </summary>
    public static InvoiceNoteCode InlandTransportDetails => new() { Value = "ITR" };

    /// <summary>
    /// Instructions regarding the testing that is required to be carried out on the items in the transaction.
    /// </summary>
    public static InvoiceNoteCode TestingInstructions => new() { Value = "ITS" };

    /// <summary>
    /// Alternative name for a location.
    /// </summary>
    public static InvoiceNoteCode LocationAlias => new() { Value = "LAN" };

    /// <summary>
    /// Note contains line item information.
    /// </summary>
    public static InvoiceNoteCode LineItem => new() { Value = "LIN" };

    /// <summary>
    /// [4080] Instructions where specified packages or containers are to be loaded on a means of transport.
    /// </summary>
    public static InvoiceNoteCode LoadingInstruction => new() { Value = "LOI" };

    /// <summary>
    /// Free text accounting information on an IATA Air Waybill to indicate payment information by Miscellaneous charge order.
    /// </summary>
    public static InvoiceNoteCode MiscellaneousChargeOrder => new() { Value = "MCO" };

    /// <summary>
    /// Information about Maritime Declaration of Health.
    /// </summary>
    public static InvoiceNoteCode MaritimeDeclarationOfHealthMDH => new() { Value = "MDH" };

    /// <summary>
    /// Additional information regarding the marks and numbers.
    /// </summary>
    public static InvoiceNoteCode AdditionalMarksNumbersInformation => new() { Value = "MKS" };

    /// <summary>
    /// Free text contains order instructions.
    /// </summary>
    public static InvoiceNoteCode OrderInstruction => new() { Value = "ORI" };

    /// <summary>
    /// General information created by the sender of general or specific value.
    /// </summary>
    public static InvoiceNoteCode OtherServiceInformation => new() { Value = "OSI" };

    /// <summary>
    /// Information regarding the packaging and/or marking of goods.
    /// </summary>
    public static InvoiceNoteCode PackingMarkingInformation => new() { Value = "PAC" };

    /// <summary>
    /// The free text contains payment instructions information relevant to the message.
    /// </summary>
    public static InvoiceNoteCode PaymentInstructionsInformation => new() { Value = "PAI" };

    /// <summary>
    /// Note contains payables information.
    /// </summary>
    public static InvoiceNoteCode PayablesInformation => new() { Value = "PAY" };

    /// <summary>
    /// Note contains packaging information.
    /// </summary>
    public static InvoiceNoteCode PackagingInformation => new() { Value = "PKG" };

    /// <summary>
    /// The text contains packaging terms information.
    /// </summary>
    public static InvoiceNoteCode PackagingTermsInformation => new() { Value = "PKT" };

    /// <summary>
    /// The free text contains payment details.
    /// </summary>
    public static InvoiceNoteCode PaymentDetailRemittanceInformation => new() { Value = "PMD" };

    /// <summary>
    /// (4438) Note contains payments information.
    /// </summary>
    public static InvoiceNoteCode PaymentInformation => new() { Value = "PMT" };

    /// <summary>
    /// The text contains product information.
    /// </summary>
    public static InvoiceNoteCode ProductInformation => new() { Value = "PRD" };

    /// <summary>
    /// Additional information regarding the price formula used for calculating the item price.
    /// </summary>
    public static InvoiceNoteCode PriceCalculationFormula => new() { Value = "PRF" };

    /// <summary>
    /// (4218) Note contains priority information.
    /// </summary>
    public static InvoiceNoteCode PriorityInformation => new() { Value = "PRI" };

    /// <summary>
    /// Note contains purchasing information.
    /// </summary>
    public static InvoiceNoteCode PurchasingInformation => new() { Value = "PUR" };

    /// <summary>
    /// Instructions regarding quarantine, i.e. the period during which an arriving vessel, including its equipment, cargo, crew or passengers, suspected to carry or carrying a contagious disease is detained in strict isolation to prevent the spread of such a disease.
    /// </summary>
    public static InvoiceNoteCode QuarantineInstructions => new() { Value = "QIN" };

    /// <summary>
    /// Specification of the quality/performance expectations or standards to which the items must conform.
    /// </summary>
    public static InvoiceNoteCode QualityDemandsRequirements => new() { Value = "QQD" };

    /// <summary>
    /// Note contains quotation information.
    /// </summary>
    public static InvoiceNoteCode QuotationInstructionInformation => new() { Value = "QUT" };

    /// <summary>
    /// Information concerning risks induced by the goods and/or handling instruction.
    /// </summary>
    public static InvoiceNoteCode RiskAndHandlingInformation => new() { Value = "RAH" };

    /// <summary>
    /// The free text contains information for regulatory authority.
    /// </summary>
    public static InvoiceNoteCode RegulatoryInformation => new() { Value = "REG" };

    /// <summary>
    /// Free text information on an IATA Air Waybill to indicate consignment returned because of non delivery.
    /// </summary>
    public static InvoiceNoteCode ReturnToOriginInformation => new() { Value = "RET" };

    /// <summary>
    /// The text contains receivables information.
    /// </summary>
    public static InvoiceNoteCode Receivables => new() { Value = "REV" };

    /// <summary>
    /// [3050] Description of a route to be used for the transport of goods.
    /// </summary>
    public static InvoiceNoteCode ConsignmentRoute => new() { Value = "RQR" };

    /// <summary>
    /// The text contains safety information.
    /// </summary>
    public static InvoiceNoteCode SafetyInformation => new() { Value = "SAF" };

    /// <summary>
    /// [4284] Instructions given and declarations made by the sender to the carrier concerning Customs, insurance, and other formalities.
    /// </summary>
    public static InvoiceNoteCode ConsignmentDocumentaryInstruction => new() { Value = "SIC" };

    /// <summary>
    /// Special instructions like licence no, high value, handle with care, glass.
    /// </summary>
    public static InvoiceNoteCode SpecialInstructions => new() { Value = "SIN" };

    /// <summary>
    /// Shipping line requested to be used for traffic between European continent and U.K. for Ireland.
    /// </summary>
    public static InvoiceNoteCode ShipLineRequested => new() { Value = "SLR" };

    /// <summary>
    /// Statement that a special permission has been obtained for the transport (and/or routing) in general, and reference to such permission.
    /// </summary>
    public static InvoiceNoteCode SpecialPermissionForTransportGenerally => new() { Value = "SPA" };

    /// <summary>
    /// Statement that a special permission has been obtained for the transport (and/or routing) of the goods specified, and reference to such permission.
    /// </summary>
    public static InvoiceNoteCode SpecialPermissionConcerningTheGoodsToBeTransported => new() { Value = "SPG" };

    /// <summary>
    /// Note contains special handling information.
    /// </summary>
    public static InvoiceNoteCode SpecialHandling => new() { Value = "SPH" };

    /// <summary>
    /// Statement that a special permission has been obtained for the packaging, and reference to such permission.
    /// </summary>
    public static InvoiceNoteCode SpecialPermissionConcerningPackage => new() { Value = "SPP" };

    /// <summary>
    /// Statement that a special permission has been obtained for the use of the means transport, and reference to such permission.
    /// </summary>
    public static InvoiceNoteCode SpecialPermissionConcerningTransportMeans => new() { Value = "SPT" };

    /// <summary>
    /// Number(s) of subsidiary risks, induced by the goods, according to the valid classification.
    /// </summary>
    public static InvoiceNoteCode SubsidiaryRiskNumberIATADGR => new() { Value = "SRN" };

    /// <summary>
    /// Request for a special service concerning the transport of the goods.
    /// </summary>
    public static InvoiceNoteCode SpecialServiceRequest => new() { Value = "SSR" };

    /// <summary>
    /// Remarks from or for a supplier of goods or services.
    /// </summary>
    public static InvoiceNoteCode SupplierRemarks => new() { Value = "SUR" };

    /// <summary>
    /// [5430] Free text specification of tariff applied to a consignment.
    /// </summary>
    public static InvoiceNoteCode ConsignmentTariff => new() { Value = "TCA" };

    /// <summary>
    /// [8012] Transport information for commercial purposes (generic term).
    /// </summary>
    public static InvoiceNoteCode ConsignmentTransport => new() { Value = "TDT" };

    /// <summary>
    /// General information regarding the transport of the cargo.
    /// </summary>
    public static InvoiceNoteCode TransportationInformation => new() { Value = "TRA" };

    /// <summary>
    /// Stipulation of the tariffs to be applied showing, where applicable, special agreement numbers or references.
    /// </summary>
    public static InvoiceNoteCode RequestedTariff => new() { Value = "TRR" };

    /// <summary>
    /// The text contains a statement constituting a tax declaration.
    /// </summary>
    public static InvoiceNoteCode TaxDeclaration => new() { Value = "TXD" };

    /// <summary>
    /// Note contains warehouse information.
    /// </summary>
    public static InvoiceNoteCode WarehouseInstructionInformation => new() { Value = "WHI" };

    /// <summary>
    /// Note contains information mutually defined by trading partners.
    /// </summary>
    public static InvoiceNoteCode MutuallyDefined => new() { Value = "ZZZ" };

    /// <summary>
    /// [4276] The free form description of the conditions of payment between the parties to a transaction.
    /// </summary>
    public static InvoiceNoteCode TermsOfPayment => new() { Value = "AAB" };
}
