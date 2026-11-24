namespace XRechnung;

/// <summary>
/// Der Betreff für den nachfolgenden Textvermerk zur Rechnung. Die Auswahl erfolgt aus UNTDID 4451.
/// </summary>
public record class InvoiceNoteCode : Code
{
    /// <summary>
    /// [7002] Plain language description of the nature of a goods item sufficient to identify it for customs, statistical or transport purposes.
    /// </summary>
    public static readonly InvoiceNoteCode GoodsItemDescription = new InvoiceNoteCode { Value = "AAA" };

    /// <summary>
    /// [4276] Free form description of the conditions of payment between the parties to a transaction.
    /// </summary>
    public static readonly InvoiceNoteCode PaymentTerm = new InvoiceNoteCode { Value = "AAB" };

    /// <summary>
    /// [7488] Additional information concerning dangerous substances and/or article in a consignment.
    /// </summary>
    public static readonly InvoiceNoteCode DangerousGoodsAdditionalInformation = new InvoiceNoteCode { Value = "AAC" };

    /// <summary>
    /// [7254] Proper shipping name, supplemented as necessary with the correct technical name, by which a dangerous substance or article may be correctly identified, or which is sufficiently informative to permit identification by reference to generally available literature.
    /// </summary>
    public static readonly InvoiceNoteCode DangerousGoodsTechnicalName = new InvoiceNoteCode { Value = "AAD" };

    /// <summary>
    /// The content of an acknowledgement.
    /// </summary>
    public static readonly InvoiceNoteCode AcknowledgementDescription = new InvoiceNoteCode { Value = "AAE" };

    /// <summary>
    /// Specific details applying to rates.
    /// </summary>
    public static readonly InvoiceNoteCode RateAdditionalInformation = new InvoiceNoteCode { Value = "AAF" };

    /// <summary>
    /// Indicates that the segment contains instructions to be passed on to the identified party.
    /// </summary>
    public static readonly InvoiceNoteCode PartyInstructions = new InvoiceNoteCode { Value = "AAG" };

    /// <summary>
    /// The text contains general information.
    /// </summary>
    public static readonly InvoiceNoteCode GeneralInformation = new InvoiceNoteCode { Value = "AAI" };

    /// <summary>
    /// Additional conditions specific to this order or project.
    /// </summary>
    public static readonly InvoiceNoteCode AdditionalConditionsOfSalePurchase = new InvoiceNoteCode { Value = "AAJ" };

    /// <summary>
    /// Information on the price conditions that are expected or given.
    /// </summary>
    public static readonly InvoiceNoteCode PriceConditions = new InvoiceNoteCode { Value = "AAK" };

    /// <summary>
    /// Expression of a number in characters as length of ten meters.
    /// </summary>
    public static readonly InvoiceNoteCode GoodsDimensionsInCharacters = new InvoiceNoteCode { Value = "AAL" };

    /// <summary>
    /// Technical or commercial reasons why a piece of equipment may not be re-used after the current transport terminates.
    /// </summary>
    public static readonly InvoiceNoteCode EquipmentReUsageRestrictions = new InvoiceNoteCode { Value = "AAM" };

    /// <summary>
    /// Restrictions in handling depending on the technical characteristics of the piece of equipment or on the nature of the goods.
    /// </summary>
    public static readonly InvoiceNoteCode HandlingRestriction = new InvoiceNoteCode { Value = "AAN" };

    /// <summary>
    /// Error described by a free text.
    /// </summary>
    public static readonly InvoiceNoteCode ErrorDescriptionFreeText = new InvoiceNoteCode { Value = "AAO" };

    /// <summary>
    /// Free text of the response to a communication.
    /// </summary>
    public static readonly InvoiceNoteCode ResponseFreeText = new InvoiceNoteCode { Value = "AAP" };

    /// <summary>
    /// A description of the contents of a package.
    /// </summary>
    public static readonly InvoiceNoteCode PackageContentSDescription = new InvoiceNoteCode { Value = "AAQ" };

    /// <summary>
    /// (4053) Free text of the non Incoterms terms of delivery. For Incoterms, use: 4053.
    /// </summary>
    public static readonly InvoiceNoteCode TermsOfDelivery = new InvoiceNoteCode { Value = "AAR" };

    /// <summary>
    /// The remarks printed or to be printed on a bill of lading.
    /// </summary>
    public static readonly InvoiceNoteCode BillOfLadingRemarks = new InvoiceNoteCode { Value = "AAS" };

    /// <summary>
    /// Free text information on an IATA Air Waybill to indicate means by which account is to be settled.
    /// </summary>
    public static readonly InvoiceNoteCode ModeOfSettlementInformation = new InvoiceNoteCode { Value = "AAT" };

    /// <summary>
    /// Information pertaining to the invoice covering the consignment.
    /// </summary>
    public static readonly InvoiceNoteCode ConsignmentInvoiceInformation = new InvoiceNoteCode { Value = "AAU" };

    /// <summary>
    /// Information pertaining to the invoice covering clearance of the cargo.
    /// </summary>
    public static readonly InvoiceNoteCode ClearanceInvoiceInformation = new InvoiceNoteCode { Value = "AAV" };

    /// <summary>
    /// Information pertaining to the letter of credit.
    /// </summary>
    public static readonly InvoiceNoteCode LetterOfCreditInformation = new InvoiceNoteCode { Value = "AAW" };

    /// <summary>
    /// Information pertaining to a license.
    /// </summary>
    public static readonly InvoiceNoteCode LicenseInformation = new InvoiceNoteCode { Value = "AAX" };

    /// <summary>
    /// The text contains certification statements.
    /// </summary>
    public static readonly InvoiceNoteCode CertificationStatements = new InvoiceNoteCode { Value = "AAY" };

    /// <summary>
    /// The text contains additional export information.
    /// </summary>
    public static readonly InvoiceNoteCode AdditionalExportInformation = new InvoiceNoteCode { Value = "AAZ" };

    /// <summary>
    /// Description of parameters relating to a tariff.
    /// </summary>
    public static readonly InvoiceNoteCode TariffStatements = new InvoiceNoteCode { Value = "ABA" };

    /// <summary>
    /// Historical details of a patients medical events.
    /// </summary>
    public static readonly InvoiceNoteCode MedicalHistory = new InvoiceNoteCode { Value = "ABB" };

    /// <summary>
    /// (4490) (4372) Additional information regarding terms and conditions which apply to the transaction.
    /// </summary>
    public static readonly InvoiceNoteCode ConditionsOfSaleOrPurchase = new InvoiceNoteCode { Value = "ABC" };

    /// <summary>
    /// [4422] Textual representation of the type of contract.
    /// </summary>
    public static readonly InvoiceNoteCode ContractDocumentType = new InvoiceNoteCode { Value = "ABD" };

    /// <summary>
    /// (4260) Additional terms and/or conditions to the documentary credit.
    /// </summary>
    public static readonly InvoiceNoteCode AdditionalTermsAndOrConditionsDocumentaryCredit = new InvoiceNoteCode { Value = "ABE" };

    /// <summary>
    /// Instruction or information about a standby documentary credit.
    /// </summary>
    public static readonly InvoiceNoteCode InstructionsOrInformationAboutStandbyDocumentaryCredit = new InvoiceNoteCode { Value = "ABF" };

    /// <summary>
    /// Instructions or information about partial shipment(s).
    /// </summary>
    public static readonly InvoiceNoteCode InstructionsOrInformationAboutPartialShipmentS = new InvoiceNoteCode { Value = "ABG" };

    /// <summary>
    /// Instructions or information about transhipment(s).
    /// </summary>
    public static readonly InvoiceNoteCode InstructionsOrInformationAboutTranshipmentS = new InvoiceNoteCode { Value = "ABH" };

    /// <summary>
    /// Additional handling instructions for a documentary credit.
    /// </summary>
    public static readonly InvoiceNoteCode AdditionalHandlingInstructionsDocumentaryCredit = new InvoiceNoteCode { Value = "ABI" };

    /// <summary>
    /// Information regarding the domestic routing.
    /// </summary>
    public static readonly InvoiceNoteCode DomesticRoutingInformation = new InvoiceNoteCode { Value = "ABJ" };

    /// <summary>
    /// Equipment types are coded by category for financial purposes.
    /// </summary>
    public static readonly InvoiceNoteCode ChargeableCategoryOfEquipment = new InvoiceNoteCode { Value = "ABK" };

    /// <summary>
    /// Information pertaining to government.
    /// </summary>
    public static readonly InvoiceNoteCode GovernmentInformation = new InvoiceNoteCode { Value = "ABL" };

    /// <summary>
    /// The text contains onward routing information.
    /// </summary>
    public static readonly InvoiceNoteCode OnwardRoutingInformation = new InvoiceNoteCode { Value = "ABM" };

    /// <summary>
    /// [4410] The text contains information related to accounting.
    /// </summary>
    public static readonly InvoiceNoteCode AccountingInformation = new InvoiceNoteCode { Value = "ABN" };

    /// <summary>
    /// Free text or coded information to indicate a specific discrepancy.
    /// </summary>
    public static readonly InvoiceNoteCode DiscrepancyInformation = new InvoiceNoteCode { Value = "ABO" };

    /// <summary>
    /// Documentary credit confirmation instructions.
    /// </summary>
    public static readonly InvoiceNoteCode ConfirmationInstructions = new InvoiceNoteCode { Value = "ABP" };

    /// <summary>
    /// Method of issuance of documentary credit.
    /// </summary>
    public static readonly InvoiceNoteCode MethodOfIssuance = new InvoiceNoteCode { Value = "ABQ" };

    /// <summary>
    /// Delivery instructions for documents required under a documentary credit.
    /// </summary>
    public static readonly InvoiceNoteCode DocumentsDeliveryInstructions = new InvoiceNoteCode { Value = "ABR" };

    /// <summary>
    /// Additional conditions to the issuance of a documentary credit.
    /// </summary>
    public static readonly InvoiceNoteCode AdditionalConditions = new InvoiceNoteCode { Value = "ABS" };

    /// <summary>
    /// Additional amounts information/instruction.
    /// </summary>
    public static readonly InvoiceNoteCode InformationInstructionsAboutAdditionalAmountsCovered = new InvoiceNoteCode { Value = "ABT" };

    /// <summary>
    /// Additional terms concerning deferred payment.
    /// </summary>
    public static readonly InvoiceNoteCode DeferredPaymentTermedAdditional = new InvoiceNoteCode { Value = "ABU" };

    /// <summary>
    /// Additional terms concerning acceptance.
    /// </summary>
    public static readonly InvoiceNoteCode AcceptanceTermsAdditional = new InvoiceNoteCode { Value = "ABV" };

    /// <summary>
    /// Additional terms concerning negotiation.
    /// </summary>
    public static readonly InvoiceNoteCode NegotiationTermsAdditional = new InvoiceNoteCode { Value = "ABW" };

    /// <summary>
    /// Document name and documentary requirements.
    /// </summary>
    public static readonly InvoiceNoteCode DocumentNameAndDocumentaryRequirements = new InvoiceNoteCode { Value = "ABX" };

    /// <summary>
    /// Instructions/information about a revolving documentary credit.
    /// </summary>
    public static readonly InvoiceNoteCode InstructionsInformationAboutRevolvingDocumentaryCredit = new InvoiceNoteCode { Value = "ABZ" };

    /// <summary>
    /// Specification of the documentary requirements.
    /// </summary>
    public static readonly InvoiceNoteCode DocumentaryRequirements = new InvoiceNoteCode { Value = "ACA" };

    /// <summary>
    /// (4270) The text contains additional information.
    /// </summary>
    public static readonly InvoiceNoteCode AdditionalInformation = new InvoiceNoteCode { Value = "ACB" };

    /// <summary>
    /// Assignment based on an agreement between seller and factor.
    /// </summary>
    public static readonly InvoiceNoteCode FactorAssignmentClause = new InvoiceNoteCode { Value = "ACC" };

    /// <summary>
    /// Reason for a request or response.
    /// </summary>
    public static readonly InvoiceNoteCode Reason = new InvoiceNoteCode { Value = "ACD" };

    /// <summary>
    /// A notice, usually from buyer to seller, that something was found wrong with goods delivered or the services rendered, or with the related invoice.
    /// </summary>
    public static readonly InvoiceNoteCode Dispute = new InvoiceNoteCode { Value = "ACE" };

    /// <summary>
    /// The text refers to information about an additional attribute not otherwise specified.
    /// </summary>
    public static readonly InvoiceNoteCode AdditionalAttributeInformation = new InvoiceNoteCode { Value = "ACF" };

    /// <summary>
    /// A declaration on the reason of the absence.
    /// </summary>
    public static readonly InvoiceNoteCode AbsenceDeclaration = new InvoiceNoteCode { Value = "ACG" };

    /// <summary>
    /// A statement on the way a specific variable or set of variables has been aggregated.
    /// </summary>
    public static readonly InvoiceNoteCode AggregationStatement = new InvoiceNoteCode { Value = "ACH" };

    /// <summary>
    /// A statement on the compilation status of an array or other set of figures or calculations.
    /// </summary>
    public static readonly InvoiceNoteCode CompilationStatement = new InvoiceNoteCode { Value = "ACI" };

    /// <summary>
    /// An exception to the agreed definition of a term, concept, formula or other object.
    /// </summary>
    public static readonly InvoiceNoteCode DefinitionalException = new InvoiceNoteCode { Value = "ACJ" };

    /// <summary>
    /// A statement on the privacy or confidential nature of an object.
    /// </summary>
    public static readonly InvoiceNoteCode PrivacyStatement = new InvoiceNoteCode { Value = "ACK" };

    /// <summary>
    /// A statement on the quality of an object.
    /// </summary>
    public static readonly InvoiceNoteCode QualityStatement = new InvoiceNoteCode { Value = "ACL" };

    /// <summary>
    /// The description of a statistical object such as a value list, concept, or structure definition.
    /// </summary>
    public static readonly InvoiceNoteCode StatisticalDescription = new InvoiceNoteCode { Value = "ACM" };

    /// <summary>
    /// The definition of a statistical object such as a value list, concept, or structure definition.
    /// </summary>
    public static readonly InvoiceNoteCode StatisticalDefinition = new InvoiceNoteCode { Value = "ACN" };

    /// <summary>
    /// The name of a statistical object such as a value list, concept or structure definition.
    /// </summary>
    public static readonly InvoiceNoteCode StatisticalName = new InvoiceNoteCode { Value = "ACO" };

    /// <summary>
    /// The title of a statistical object such as a value list, concept, or structure definition.
    /// </summary>
    public static readonly InvoiceNoteCode StatisticalTitle = new InvoiceNoteCode { Value = "ACP" };

    /// <summary>
    /// Information relating to differences between the actual transport dimensions and the normally applicable dimensions.
    /// </summary>
    public static readonly InvoiceNoteCode OffDimensionInformation = new InvoiceNoteCode { Value = "ACQ" };

    /// <summary>
    /// Information relating to unexpected stops during a conveyance.
    /// </summary>
    public static readonly InvoiceNoteCode UnexpectedStopsInformation = new InvoiceNoteCode { Value = "ACR" };

    /// <summary>
    /// Text subject is principles section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static readonly InvoiceNoteCode Principles = new InvoiceNoteCode { Value = "ACS" };

    /// <summary>
    /// Text subject is terms and definition section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static readonly InvoiceNoteCode TermsAndDefinition = new InvoiceNoteCode { Value = "ACT" };

    /// <summary>
    /// Text subject is segment name.
    /// </summary>
    public static readonly InvoiceNoteCode SegmentName = new InvoiceNoteCode { Value = "ACU" };

    /// <summary>
    /// Text subject is name of simple data element.
    /// </summary>
    public static readonly InvoiceNoteCode SimpleDataElementName = new InvoiceNoteCode { Value = "ACV" };

    /// <summary>
    /// Text subject is scope section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static readonly InvoiceNoteCode Scope = new InvoiceNoteCode { Value = "ACW" };

    /// <summary>
    /// Text subject is name of message type.
    /// </summary>
    public static readonly InvoiceNoteCode MessageTypeName = new InvoiceNoteCode { Value = "ACX" };

    /// <summary>
    /// Text subject is introduction section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static readonly InvoiceNoteCode Introduction = new InvoiceNoteCode { Value = "ACY" };

    /// <summary>
    /// Text subject is glossary section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static readonly InvoiceNoteCode Glossary = new InvoiceNoteCode { Value = "ACZ" };

    /// <summary>
    /// Text subject is functional definition section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static readonly InvoiceNoteCode FunctionalDefinition = new InvoiceNoteCode { Value = "ADA" };

    /// <summary>
    /// Text subject is examples as given in the example(s) section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static readonly InvoiceNoteCode Examples = new InvoiceNoteCode { Value = "ADB" };

    /// <summary>
    /// Text subject is cover page of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static readonly InvoiceNoteCode CoverPage = new InvoiceNoteCode { Value = "ADC" };

    /// <summary>
    /// Denotes that the associated text is a dependency (syntax) note.
    /// </summary>
    public static readonly InvoiceNoteCode DependencySyntaxNotes = new InvoiceNoteCode { Value = "ADD" };

    /// <summary>
    /// Text subject is name of code value.
    /// </summary>
    public static readonly InvoiceNoteCode CodeValueName = new InvoiceNoteCode { Value = "ADE" };

    /// <summary>
    /// Text subject is name of code list.
    /// </summary>
    public static readonly InvoiceNoteCode CodeListName = new InvoiceNoteCode { Value = "ADF" };

    /// <summary>
    /// Text subject is an explanation of the intended usage of a segment or segment group.
    /// </summary>
    public static readonly InvoiceNoteCode ClarificationOfUsage = new InvoiceNoteCode { Value = "ADG" };

    /// <summary>
    /// Text subject is name of composite data element.
    /// </summary>
    public static readonly InvoiceNoteCode CompositeDataElementName = new InvoiceNoteCode { Value = "ADH" };

    /// <summary>
    /// Text subject is field of application of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
    /// </summary>
    public static readonly InvoiceNoteCode FieldOfApplication = new InvoiceNoteCode { Value = "ADI" };

    /// <summary>
    /// Information describing the type of assets and liabilities.
    /// </summary>
    public static readonly InvoiceNoteCode TypeOfAssetsAndLiabilities = new InvoiceNoteCode { Value = "ADJ" };

    /// <summary>
    /// The text contains information about a promotion.
    /// </summary>
    public static readonly InvoiceNoteCode PromotionInformation = new InvoiceNoteCode { Value = "ADK" };

    /// <summary>
    /// Description of the condition of a meter.
    /// </summary>
    public static readonly InvoiceNoteCode MeterCondition = new InvoiceNoteCode { Value = "ADL" };

    /// <summary>
    /// Information related to a particular reading of a meter.
    /// </summary>
    public static readonly InvoiceNoteCode MeterReadingInformation = new InvoiceNoteCode { Value = "ADM" };

    /// <summary>
    /// Information describing the type of the reason of transaction.
    /// </summary>
    public static readonly InvoiceNoteCode TypeOfTransactionReason = new InvoiceNoteCode { Value = "ADN" };

    /// <summary>
    /// Type of survey question.
    /// </summary>
    public static readonly InvoiceNoteCode TypeOfSurveyQuestion = new InvoiceNoteCode { Value = "ADO" };

    /// <summary>
    /// Information for use at the counter of the carrier's agent.
    /// </summary>
    public static readonly InvoiceNoteCode CarrierSAgentCounterInformation = new InvoiceNoteCode { Value = "ADP" };

    /// <summary>
    /// Description or code for the operation to be executed on the equipment.
    /// </summary>
    public static readonly InvoiceNoteCode DescriptionOfWorkItemOnEquipment = new InvoiceNoteCode { Value = "ADQ" };

    /// <summary>
    /// Text subject is message definition.
    /// </summary>
    public static readonly InvoiceNoteCode MessageDefinition = new InvoiceNoteCode { Value = "ADR" };

    /// <summary>
    /// Information pertaining to a booked item.
    /// </summary>
    public static readonly InvoiceNoteCode BookedItemInformation = new InvoiceNoteCode { Value = "ADS" };

    /// <summary>
    /// Text subject is source of document.
    /// </summary>
    public static readonly InvoiceNoteCode SourceOfDocument = new InvoiceNoteCode { Value = "ADT" };

    /// <summary>
    /// Text subject is note.
    /// </summary>
    public static readonly InvoiceNoteCode Note = new InvoiceNoteCode { Value = "ADU" };

    /// <summary>
    /// Text subject is fixed part of segment clarification text.
    /// </summary>
    public static readonly InvoiceNoteCode FixedPartOfSegmentClarificationText = new InvoiceNoteCode { Value = "ADV" };

    /// <summary>
    /// Description of the characteristic of goods in addition to the description of the goods.
    /// </summary>
    public static readonly InvoiceNoteCode CharacteristicsOfGoods = new InvoiceNoteCode { Value = "ADW" };

    /// <summary>
    /// Special discharge instructions concerning the goods.
    /// </summary>
    public static readonly InvoiceNoteCode AdditionalDischargeInstructions = new InvoiceNoteCode { Value = "ADX" };

    /// <summary>
    /// Instructions regarding the stripping of container(s).
    /// </summary>
    public static readonly InvoiceNoteCode ContainerStrippingInstructions = new InvoiceNoteCode { Value = "ADY" };

    /// <summary>
    /// Information on the CSC (Container Safety Convention) plate that is attached to the container.
    /// </summary>
    public static readonly InvoiceNoteCode CSCContainerSafetyConventionPlateInformation = new InvoiceNoteCode { Value = "ADZ" };

    /// <summary>
    /// Additional remarks concerning the cargo.
    /// </summary>
    public static readonly InvoiceNoteCode CargoRemarks = new InvoiceNoteCode { Value = "AEA" };

    /// <summary>
    /// Instruction regarding the temperature control of the cargo.
    /// </summary>
    public static readonly InvoiceNoteCode TemperatureControlInstructions = new InvoiceNoteCode { Value = "AEB" };

    /// <summary>
    /// Remarks refer to data that was expected.
    /// </summary>
    public static readonly InvoiceNoteCode TextRefersToExpectedData = new InvoiceNoteCode { Value = "AEC" };

    /// <summary>
    /// Remarks refer to data that was received.
    /// </summary>
    public static readonly InvoiceNoteCode TextRefersToReceivedData = new InvoiceNoteCode { Value = "AED" };

    /// <summary>
    /// Text subject is section clarification text.
    /// </summary>
    public static readonly InvoiceNoteCode SectionClarificationText = new InvoiceNoteCode { Value = "AEE" };

    /// <summary>
    /// Information given to the beneficiary.
    /// </summary>
    public static readonly InvoiceNoteCode InformationToTheBeneficiary = new InvoiceNoteCode { Value = "AEF" };

    /// <summary>
    /// Information given to the applicant.
    /// </summary>
    public static readonly InvoiceNoteCode InformationToTheApplicant = new InvoiceNoteCode { Value = "AEG" };

    /// <summary>
    /// Instructions made to the beneficiary.
    /// </summary>
    public static readonly InvoiceNoteCode InstructionsToTheBeneficiary = new InvoiceNoteCode { Value = "AEH" };

    /// <summary>
    /// Instructions given to the applicant.
    /// </summary>
    public static readonly InvoiceNoteCode InstructionsToTheApplicant = new InvoiceNoteCode { Value = "AEI" };

    /// <summary>
    /// Information about the controlled atmosphere.
    /// </summary>
    public static readonly InvoiceNoteCode ControlledAtmosphere = new InvoiceNoteCode { Value = "AEJ" };

    /// <summary>
    /// Additional information in plain text to support a take off annotation. Taking off is the process of assessing the quantity work from extracting the measurement from construction documentation.
    /// </summary>
    public static readonly InvoiceNoteCode TakeOffAnnotation = new InvoiceNoteCode { Value = "AEK" };

    /// <summary>
    /// Additional information in plain language to support a price variation.
    /// </summary>
    public static readonly InvoiceNoteCode PriceVariationNarrative = new InvoiceNoteCode { Value = "AEL" };

    /// <summary>
    /// Documentary credit amendment instructions.
    /// </summary>
    public static readonly InvoiceNoteCode DocumentaryCreditAmendmentInstructions = new InvoiceNoteCode { Value = "AEM" };

    /// <summary>
    /// Additional information in plain language to support a standard method.
    /// </summary>
    public static readonly InvoiceNoteCode StandardMethodNarrative = new InvoiceNoteCode { Value = "AEN" };

    /// <summary>
    /// Additional information in plain language to support the project.
    /// </summary>
    public static readonly InvoiceNoteCode ProjectNarrative = new InvoiceNoteCode { Value = "AEO" };

    /// <summary>
    /// Additional information related to radioactive goods.
    /// </summary>
    public static readonly InvoiceNoteCode RadioactiveGoodsAdditionalInformation = new InvoiceNoteCode { Value = "AEP" };

    /// <summary>
    /// Information given from one bank to another.
    /// </summary>
    public static readonly InvoiceNoteCode BankToBankInformation = new InvoiceNoteCode { Value = "AEQ" };

    /// <summary>
    /// Instructions given for reimbursement purposes.
    /// </summary>
    public static readonly InvoiceNoteCode ReimbursementInstructions = new InvoiceNoteCode { Value = "AER" };

    /// <summary>
    /// Identification of the reason for amending a message.
    /// </summary>
    public static readonly InvoiceNoteCode ReasonForAmendingAMessage = new InvoiceNoteCode { Value = "AES" };

    /// <summary>
    /// Instructions to the paying and/or accepting and/or negotiating bank.
    /// </summary>
    public static readonly InvoiceNoteCode InstructionsToThePayingAndOrAcceptingAndOrNegotiatingBank = new InvoiceNoteCode { Value = "AET" };

    /// <summary>
    /// Instructions given about the interest.
    /// </summary>
    public static readonly InvoiceNoteCode InterestInstructions = new InvoiceNoteCode { Value = "AEU" };

    /// <summary>
    /// Instructions about agent commission.
    /// </summary>
    public static readonly InvoiceNoteCode AgentCommission = new InvoiceNoteCode { Value = "AEV" };

    /// <summary>
    /// Instructions to the remitting bank.
    /// </summary>
    public static readonly InvoiceNoteCode RemittingBankInstructions = new InvoiceNoteCode { Value = "AEW" };

    /// <summary>
    /// Instructions to the bank, other than the remitting bank, involved in processing the collection.
    /// </summary>
    public static readonly InvoiceNoteCode InstructionsToTheCollectingBank = new InvoiceNoteCode { Value = "AEX" };

    /// <summary>
    /// Instructions about the collection amount.
    /// </summary>
    public static readonly InvoiceNoteCode CollectionAmountInstructions = new InvoiceNoteCode { Value = "AEY" };

    /// <summary>
    /// Text relating to internal auditing information.
    /// </summary>
    public static readonly InvoiceNoteCode InternalAuditingInformation = new InvoiceNoteCode { Value = "AEZ" };

    /// <summary>
    /// Denotes that the associated text is a constraint.
    /// </summary>
    public static readonly InvoiceNoteCode Constraint = new InvoiceNoteCode { Value = "AFA" };

    /// <summary>
    /// Denotes that the associated text is a comment.
    /// </summary>
    public static readonly InvoiceNoteCode Comment = new InvoiceNoteCode { Value = "AFB" };

    /// <summary>
    /// Denotes that the associated text is a semantic note.
    /// </summary>
    public static readonly InvoiceNoteCode SemanticNote = new InvoiceNoteCode { Value = "AFC" };

    /// <summary>
    /// Denotes that the associated text is an item of help text.
    /// </summary>
    public static readonly InvoiceNoteCode HelpText = new InvoiceNoteCode { Value = "AFD" };

    /// <summary>
    /// Denotes that the associated text is a legend.
    /// </summary>
    public static readonly InvoiceNoteCode Legend = new InvoiceNoteCode { Value = "AFE" };

    /// <summary>
    /// A description of the structure of a batch code.
    /// </summary>
    public static readonly InvoiceNoteCode BatchCodeStructure = new InvoiceNoteCode { Value = "AFF" };

    /// <summary>
    /// A general description of the application of a product.
    /// </summary>
    public static readonly InvoiceNoteCode ProductApplication = new InvoiceNoteCode { Value = "AFG" };

    /// <summary>
    /// Complaint of customer.
    /// </summary>
    public static readonly InvoiceNoteCode CustomerComplaint = new InvoiceNoteCode { Value = "AFH" };

    /// <summary>
    /// The probable cause of fault.
    /// </summary>
    public static readonly InvoiceNoteCode ProbableCauseOfFault = new InvoiceNoteCode { Value = "AFI" };

    /// <summary>
    /// Description of the defect.
    /// </summary>
    public static readonly InvoiceNoteCode DefectDescription = new InvoiceNoteCode { Value = "AFJ" };

    /// <summary>
    /// The description of the work performed during the repair.
    /// </summary>
    public static readonly InvoiceNoteCode RepairDescription = new InvoiceNoteCode { Value = "AFK" };

    /// <summary>
    /// Comments relevant to a review.
    /// </summary>
    public static readonly InvoiceNoteCode ReviewComments = new InvoiceNoteCode { Value = "AFL" };

    /// <summary>
    /// Denotes that the associated text is a title.
    /// </summary>
    public static readonly InvoiceNoteCode Title = new InvoiceNoteCode { Value = "AFM" };

    /// <summary>
    /// An amount description in clear text.
    /// </summary>
    public static readonly InvoiceNoteCode DescriptionOfAmount = new InvoiceNoteCode { Value = "AFN" };

    /// <summary>
    /// Information describing the responsibilities.
    /// </summary>
    public static readonly InvoiceNoteCode Responsibilities = new InvoiceNoteCode { Value = "AFO" };

    /// <summary>
    /// Information concerning suppliers.
    /// </summary>
    public static readonly InvoiceNoteCode Supplier = new InvoiceNoteCode { Value = "AFP" };

    /// <summary>
    /// Information concerning the region(s) where purchases are made.
    /// </summary>
    public static readonly InvoiceNoteCode PurchaseRegion = new InvoiceNoteCode { Value = "AFQ" };

    /// <summary>
    /// Information concerning an association of one party with another party(ies).
    /// </summary>
    public static readonly InvoiceNoteCode Affiliation = new InvoiceNoteCode { Value = "AFR" };

    /// <summary>
    /// Information concerning the borrower.
    /// </summary>
    public static readonly InvoiceNoteCode Borrower = new InvoiceNoteCode { Value = "AFS" };

    /// <summary>
    /// Information concerning an entity's line of business.
    /// </summary>
    public static readonly InvoiceNoteCode LineOfBusiness = new InvoiceNoteCode { Value = "AFT" };

    /// <summary>
    /// Description of financial institution(s) used by an entity.
    /// </summary>
    public static readonly InvoiceNoteCode FinancialInstitution = new InvoiceNoteCode { Value = "AFU" };

    /// <summary>
    /// Information about the business founder.
    /// </summary>
    public static readonly InvoiceNoteCode BusinessFounder = new InvoiceNoteCode { Value = "AFV" };

    /// <summary>
    /// Description of the business history.
    /// </summary>
    public static readonly InvoiceNoteCode BusinessHistory = new InvoiceNoteCode { Value = "AFW" };

    /// <summary>
    /// Information concerning the general banking arrangements.
    /// </summary>
    public static readonly InvoiceNoteCode BankingArrangements = new InvoiceNoteCode { Value = "AFX" };

    /// <summary>
    /// Description of the business origin.
    /// </summary>
    public static readonly InvoiceNoteCode BusinessOrigin = new InvoiceNoteCode { Value = "AFY" };

    /// <summary>
    /// Description of the entity's brands.
    /// </summary>
    public static readonly InvoiceNoteCode BrandNamesDescription = new InvoiceNoteCode { Value = "AFZ" };

    /// <summary>
    /// Details about the financing of the business.
    /// </summary>
    public static readonly InvoiceNoteCode BusinessFinancingDetails = new InvoiceNoteCode { Value = "AGA" };

    /// <summary>
    /// Information concerning an entity's competition.
    /// </summary>
    public static readonly InvoiceNoteCode Competition = new InvoiceNoteCode { Value = "AGB" };

    /// <summary>
    /// Details about the construction process.
    /// </summary>
    public static readonly InvoiceNoteCode ConstructionProcessDetails = new InvoiceNoteCode { Value = "AGC" };

    /// <summary>
    /// Information concerning the line of business of a construction entity.
    /// </summary>
    public static readonly InvoiceNoteCode ConstructionSpecialty = new InvoiceNoteCode { Value = "AGD" };

    /// <summary>
    /// Details about contract(s).
    /// </summary>
    public static readonly InvoiceNoteCode ContractInformation = new InvoiceNoteCode { Value = "AGE" };

    /// <summary>
    /// Details about a corporate filing.
    /// </summary>
    public static readonly InvoiceNoteCode CorporateFiling = new InvoiceNoteCode { Value = "AGF" };

    /// <summary>
    /// Description of customers.
    /// </summary>
    public static readonly InvoiceNoteCode CustomerInformation = new InvoiceNoteCode { Value = "AGG" };

    /// <summary>
    /// Information concerning the copyright notice.
    /// </summary>
    public static readonly InvoiceNoteCode CopyrightNotice = new InvoiceNoteCode { Value = "AGH" };

    /// <summary>
    /// Details about the contingent debt.
    /// </summary>
    public static readonly InvoiceNoteCode ContingentDebt = new InvoiceNoteCode { Value = "AGI" };

    /// <summary>
    /// Details about the law or penal codes that resulted in conviction.
    /// </summary>
    public static readonly InvoiceNoteCode ConvictionDetails = new InvoiceNoteCode { Value = "AGJ" };

    /// <summary>
    /// Description of equipment.
    /// </summary>
    public static readonly InvoiceNoteCode Equipment = new InvoiceNoteCode { Value = "AGK" };

    /// <summary>
    /// Comments about the workforce.
    /// </summary>
    public static readonly InvoiceNoteCode WorkforceDescription = new InvoiceNoteCode { Value = "AGL" };

    /// <summary>
    /// Description about exemptions.
    /// </summary>
    public static readonly InvoiceNoteCode Exemption = new InvoiceNoteCode { Value = "AGM" };

    /// <summary>
    /// Information on future plans.
    /// </summary>
    public static readonly InvoiceNoteCode FuturePlans = new InvoiceNoteCode { Value = "AGN" };

    /// <summary>
    /// Information concerning the interviewee conversation.
    /// </summary>
    public static readonly InvoiceNoteCode IntervieweeConversationInformation = new InvoiceNoteCode { Value = "AGO" };

    /// <summary>
    /// Description of intangible asset(s).
    /// </summary>
    public static readonly InvoiceNoteCode IntangibleAsset = new InvoiceNoteCode { Value = "AGP" };

    /// <summary>
    /// Description of the inventory.
    /// </summary>
    public static readonly InvoiceNoteCode Inventory = new InvoiceNoteCode { Value = "AGQ" };

    /// <summary>
    /// Description of the investments.
    /// </summary>
    public static readonly InvoiceNoteCode Investment = new InvoiceNoteCode { Value = "AGR" };

    /// <summary>
    /// Description of the intercompany relations.
    /// </summary>
    public static readonly InvoiceNoteCode IntercompanyRelationsInformation = new InvoiceNoteCode { Value = "AGS" };

    /// <summary>
    /// Description of the joint venture.
    /// </summary>
    public static readonly InvoiceNoteCode JointVenture = new InvoiceNoteCode { Value = "AGT" };

    /// <summary>
    /// Description of a loan.
    /// </summary>
    public static readonly InvoiceNoteCode Loan = new InvoiceNoteCode { Value = "AGU" };

    /// <summary>
    /// Description of the long term debt.
    /// </summary>
    public static readonly InvoiceNoteCode LongTermDebt = new InvoiceNoteCode { Value = "AGV" };

    /// <summary>
    /// Description of a location.
    /// </summary>
    public static readonly InvoiceNoteCode Location = new InvoiceNoteCode { Value = "AGW" };

    /// <summary>
    /// Details on the current legal structure.
    /// </summary>
    public static readonly InvoiceNoteCode CurrentLegalStructure = new InvoiceNoteCode { Value = "AGX" };

    /// <summary>
    /// Details on a marital contract.
    /// </summary>
    public static readonly InvoiceNoteCode MaritalContract = new InvoiceNoteCode { Value = "AGY" };

    /// <summary>
    /// Information concerning marketing activities.
    /// </summary>
    public static readonly InvoiceNoteCode MarketingActivities = new InvoiceNoteCode { Value = "AGZ" };

    /// <summary>
    /// Description of a merger.
    /// </summary>
    public static readonly InvoiceNoteCode Merger = new InvoiceNoteCode { Value = "AHA" };

    /// <summary>
    /// Description of the marketable securities.
    /// </summary>
    public static readonly InvoiceNoteCode MarketableSecurities = new InvoiceNoteCode { Value = "AHB" };

    /// <summary>
    /// Description of the business debt(s).
    /// </summary>
    public static readonly InvoiceNoteCode BusinessDebt = new InvoiceNoteCode { Value = "AHC" };

    /// <summary>
    /// Information concerning the original legal structure.
    /// </summary>
    public static readonly InvoiceNoteCode OriginalLegalStructure = new InvoiceNoteCode { Value = "AHD" };

    /// <summary>
    /// Information describing how a company uses employees from another company.
    /// </summary>
    public static readonly InvoiceNoteCode EmployeeSharingArrangements = new InvoiceNoteCode { Value = "AHE" };

    /// <summary>
    /// Description about the organization of a company.
    /// </summary>
    public static readonly InvoiceNoteCode OrganizationDetails = new InvoiceNoteCode { Value = "AHF" };

    /// <summary>
    /// Information concerning public records.
    /// </summary>
    public static readonly InvoiceNoteCode PublicRecordDetails = new InvoiceNoteCode { Value = "AHG" };

    /// <summary>
    /// Information concerning the price range of products made or sold.
    /// </summary>
    public static readonly InvoiceNoteCode PriceRange = new InvoiceNoteCode { Value = "AHH" };

    /// <summary>
    /// Information on the accomplishments fitting a party for a position.
    /// </summary>
    public static readonly InvoiceNoteCode Qualifications = new InvoiceNoteCode { Value = "AHI" };

    /// <summary>
    /// Information concerning the registered activity.
    /// </summary>
    public static readonly InvoiceNoteCode RegisteredActivity = new InvoiceNoteCode { Value = "AHJ" };

    /// <summary>
    /// Description of the sentence imposed in a criminal proceeding.
    /// </summary>
    public static readonly InvoiceNoteCode CriminalSentence = new InvoiceNoteCode { Value = "AHK" };

    /// <summary>
    /// Description of the selling means.
    /// </summary>
    public static readonly InvoiceNoteCode SalesMethod = new InvoiceNoteCode { Value = "AHL" };

    /// <summary>
    /// Free form description relating to the school(s) attended.
    /// </summary>
    public static readonly InvoiceNoteCode EducationalInstitutionInformation = new InvoiceNoteCode { Value = "AHM" };

    /// <summary>
    /// Describes the status details.
    /// </summary>
    public static readonly InvoiceNoteCode StatusDetails = new InvoiceNoteCode { Value = "AHN" };

    /// <summary>
    /// Description of the sales.
    /// </summary>
    public static readonly InvoiceNoteCode Sales = new InvoiceNoteCode { Value = "AHO" };

    /// <summary>
    /// Information about the spouse.
    /// </summary>
    public static readonly InvoiceNoteCode SpouseInformation = new InvoiceNoteCode { Value = "AHP" };

    /// <summary>
    /// Details about the educational degree received from a school.
    /// </summary>
    public static readonly InvoiceNoteCode EducationalDegreeInformation = new InvoiceNoteCode { Value = "AHQ" };

    /// <summary>
    /// General description of shareholding.
    /// </summary>
    public static readonly InvoiceNoteCode ShareholdingInformation = new InvoiceNoteCode { Value = "AHR" };

    /// <summary>
    /// Information on the sales territory.
    /// </summary>
    public static readonly InvoiceNoteCode SalesTerritory = new InvoiceNoteCode { Value = "AHS" };

    /// <summary>
    /// Comments made by an accountant regarding a financial statement.
    /// </summary>
    public static readonly InvoiceNoteCode AccountantSComments = new InvoiceNoteCode { Value = "AHT" };

    /// <summary>
    /// Description of the exemption provided to a location by a law.
    /// </summary>
    public static readonly InvoiceNoteCode ExemptionLawLocation = new InvoiceNoteCode { Value = "AHU" };

    /// <summary>
    /// Information about the classes or categories of shares.
    /// </summary>
    public static readonly InvoiceNoteCode ShareClassifications = new InvoiceNoteCode { Value = "AHV" };

    /// <summary>
    /// Description of a prediction.
    /// </summary>
    public static readonly InvoiceNoteCode Forecast = new InvoiceNoteCode { Value = "AHW" };

    /// <summary>
    /// Description of the location of an event.
    /// </summary>
    public static readonly InvoiceNoteCode EventLocation = new InvoiceNoteCode { Value = "AHX" };

    /// <summary>
    /// Information related to occupancy of a facility.
    /// </summary>
    public static readonly InvoiceNoteCode FacilityOccupancy = new InvoiceNoteCode { Value = "AHY" };

    /// <summary>
    /// Specific information provided about the importation and exportation of goods.
    /// </summary>
    public static readonly InvoiceNoteCode ImportAndExportDetails = new InvoiceNoteCode { Value = "AHZ" };

    /// <summary>
    /// Additional information about a facility.
    /// </summary>
    public static readonly InvoiceNoteCode AdditionalFacilityInformation = new InvoiceNoteCode { Value = "AIA" };

    /// <summary>
    /// Description of the value of inventory.
    /// </summary>
    public static readonly InvoiceNoteCode InventoryValue = new InvoiceNoteCode { Value = "AIB" };

    /// <summary>
    /// Description of the education of a person.
    /// </summary>
    public static readonly InvoiceNoteCode Education = new InvoiceNoteCode { Value = "AIC" };

    /// <summary>
    /// Description of a thing that happens or takes place.
    /// </summary>
    public static readonly InvoiceNoteCode Event = new InvoiceNoteCode { Value = "AID" };

    /// <summary>
    /// Information about agents the entity uses.
    /// </summary>
    public static readonly InvoiceNoteCode Agent = new InvoiceNoteCode { Value = "AIE" };

    /// <summary>
    /// Details of domestically agreed financial statement.
    /// </summary>
    public static readonly InvoiceNoteCode DomesticallyAgreedFinancialStatementDetails = new InvoiceNoteCode { Value = "AIF" };

    /// <summary>
    /// Description of other current asset.
    /// </summary>
    public static readonly InvoiceNoteCode OtherCurrentAssetDescription = new InvoiceNoteCode { Value = "AIG" };

    /// <summary>
    /// Description of other current liability.
    /// </summary>
    public static readonly InvoiceNoteCode OtherCurrentLiabilityDescription = new InvoiceNoteCode { Value = "AIH" };

    /// <summary>
    /// Description of the former line of business.
    /// </summary>
    public static readonly InvoiceNoteCode FormerBusinessActivity = new InvoiceNoteCode { Value = "AII" };

    /// <summary>
    /// Description of how a trading name is used.
    /// </summary>
    public static readonly InvoiceNoteCode TradeNameUse = new InvoiceNoteCode { Value = "AIJ" };

    /// <summary>
    /// Description of the authorized signatory.
    /// </summary>
    public static readonly InvoiceNoteCode SigningAuthority = new InvoiceNoteCode { Value = "AIK" };

    /// <summary>
    /// [4376] Description of guarantee.
    /// </summary>
    public static readonly InvoiceNoteCode Guarantee = new InvoiceNoteCode { Value = "AIL" };

    /// <summary>
    /// Description of the operation of a holding company.
    /// </summary>
    public static readonly InvoiceNoteCode HoldingCompanyOperation = new InvoiceNoteCode { Value = "AIM" };

    /// <summary>
    /// Information on routing of the consignment.
    /// </summary>
    public static readonly InvoiceNoteCode ConsignmentRouting = new InvoiceNoteCode { Value = "AIN" };

    /// <summary>
    /// A letter citing any condition in dispute.
    /// </summary>
    public static readonly InvoiceNoteCode LetterOfProtest = new InvoiceNoteCode { Value = "AIO" };

    /// <summary>
    /// A free text question.
    /// </summary>
    public static readonly InvoiceNoteCode Question = new InvoiceNoteCode { Value = "AIP" };

    /// <summary>
    /// Free text information related to a party.
    /// </summary>
    public static readonly InvoiceNoteCode PartyInformation = new InvoiceNoteCode { Value = "AIQ" };

    /// <summary>
    /// Description of the boundaries of a geographical area.
    /// </summary>
    public static readonly InvoiceNoteCode AreaBoundariesDescription = new InvoiceNoteCode { Value = "AIR" };

    /// <summary>
    /// The free text contains advertisement information.
    /// </summary>
    public static readonly InvoiceNoteCode AdvertisementInformation = new InvoiceNoteCode { Value = "AIS" };

    /// <summary>
    /// Details regarding the financial statement in free text.
    /// </summary>
    public static readonly InvoiceNoteCode FinancialStatementDetails = new InvoiceNoteCode { Value = "AIT" };

    /// <summary>
    /// Description of how to access an entity.
    /// </summary>
    public static readonly InvoiceNoteCode AccessInstructions = new InvoiceNoteCode { Value = "AIU" };

    /// <summary>
    /// Description of an entity's liquidity.
    /// </summary>
    public static readonly InvoiceNoteCode Liquidity = new InvoiceNoteCode { Value = "AIV" };

    /// <summary>
    /// Description of the line of credit available to an entity.
    /// </summary>
    public static readonly InvoiceNoteCode CreditLine = new InvoiceNoteCode { Value = "AIW" };

    /// <summary>
    /// Text describing the terms of warranty which apply to a product or service.
    /// </summary>
    public static readonly InvoiceNoteCode WarrantyTerms = new InvoiceNoteCode { Value = "AIX" };

    /// <summary>
    /// Plain language description of a division of an entity.
    /// </summary>
    public static readonly InvoiceNoteCode DivisionDescription = new InvoiceNoteCode { Value = "AIY" };

    /// <summary>
    /// Instruction on how to report.
    /// </summary>
    public static readonly InvoiceNoteCode ReportingInstruction = new InvoiceNoteCode { Value = "AIZ" };

    /// <summary>
    /// The result of an examination.
    /// </summary>
    public static readonly InvoiceNoteCode ExaminationResult = new InvoiceNoteCode { Value = "AJA" };

    /// <summary>
    /// The result of a laboratory investigation.
    /// </summary>
    public static readonly InvoiceNoteCode LaboratoryResult = new InvoiceNoteCode { Value = "AJB" };

    /// <summary>
    /// Information referring to allowance/charge.
    /// </summary>
    public static readonly InvoiceNoteCode AllowanceChargeInformation = new InvoiceNoteCode { Value = "ALC" };

    /// <summary>
    /// The result of an X-ray examination.
    /// </summary>
    public static readonly InvoiceNoteCode XRayResult = new InvoiceNoteCode { Value = "ALD" };

    /// <summary>
    /// The result of a pathology investigation.
    /// </summary>
    public static readonly InvoiceNoteCode PathologyResult = new InvoiceNoteCode { Value = "ALE" };

    /// <summary>
    /// Details of an intervention.
    /// </summary>
    public static readonly InvoiceNoteCode InterventionDescription = new InvoiceNoteCode { Value = "ALF" };

    /// <summary>
    /// Summary description of admittance.
    /// </summary>
    public static readonly InvoiceNoteCode SummaryOfAdmittance = new InvoiceNoteCode { Value = "ALG" };

    /// <summary>
    /// Details of a course of medical treatment.
    /// </summary>
    public static readonly InvoiceNoteCode MedicalTreatmentCourseDetail = new InvoiceNoteCode { Value = "ALH" };

    /// <summary>
    /// Details of a prognosis.
    /// </summary>
    public static readonly InvoiceNoteCode Prognosis = new InvoiceNoteCode { Value = "ALI" };

    /// <summary>
    /// Instruction given to a patient.
    /// </summary>
    public static readonly InvoiceNoteCode InstructionToPatient = new InvoiceNoteCode { Value = "ALJ" };

    /// <summary>
    /// Instruction given to a physician.
    /// </summary>
    public static readonly InvoiceNoteCode InstructionToPhysician = new InvoiceNoteCode { Value = "ALK" };

    /// <summary>
    /// The note implies to all documents.
    /// </summary>
    public static readonly InvoiceNoteCode AllDocuments = new InvoiceNoteCode { Value = "ALL" };

    /// <summary>
    /// Details of medicine treatment.
    /// </summary>
    public static readonly InvoiceNoteCode MedicineTreatment = new InvoiceNoteCode { Value = "ALM" };

    /// <summary>
    /// Details of medicine dosage and method of administration.
    /// </summary>
    public static readonly InvoiceNoteCode MedicineDosageAndAdministration = new InvoiceNoteCode { Value = "ALN" };

    /// <summary>
    /// Details of when and/or where the patient is available.
    /// </summary>
    public static readonly InvoiceNoteCode AvailabilityOfPatient = new InvoiceNoteCode { Value = "ALO" };

    /// <summary>
    /// Details of the reason for a requested service.
    /// </summary>
    public static readonly InvoiceNoteCode ReasonForServiceRequest = new InvoiceNoteCode { Value = "ALP" };

    /// <summary>
    /// Details of the purpose of a service.
    /// </summary>
    public static readonly InvoiceNoteCode PurposeOfService = new InvoiceNoteCode { Value = "ALQ" };

    /// <summary>
    /// Conditions under which arrival takes place.
    /// </summary>
    public static readonly InvoiceNoteCode ArrivalConditions = new InvoiceNoteCode { Value = "ARR" };

    /// <summary>
    /// Comment by the requester of a service.
    /// </summary>
    public static readonly InvoiceNoteCode ServiceRequesterSComment = new InvoiceNoteCode { Value = "ARS" };

    /// <summary>
    /// (4130) (4136) (4426) Name, code, password etc. given for authentication purposes.
    /// </summary>
    public static readonly InvoiceNoteCode Authentication = new InvoiceNoteCode { Value = "AUT" };

    /// <summary>
    /// The description of the location requested.
    /// </summary>
    public static readonly InvoiceNoteCode RequestedLocationDescription = new InvoiceNoteCode { Value = "AUU" };

    /// <summary>
    /// The event or condition that initiates the administration of a single dose of medicine or a period of treatment.
    /// </summary>
    public static readonly InvoiceNoteCode MedicineAdministrationCondition = new InvoiceNoteCode { Value = "AUV" };

    /// <summary>
    /// Information concerning a patient.
    /// </summary>
    public static readonly InvoiceNoteCode PatientInformation = new InvoiceNoteCode { Value = "AUW" };

    /// <summary>
    /// Action to be taken to avert possible harmful affects.
    /// </summary>
    public static readonly InvoiceNoteCode PrecautionaryMeasure = new InvoiceNoteCode { Value = "AUX" };

    /// <summary>
    /// Free text description is related to a service characteristic.
    /// </summary>
    public static readonly InvoiceNoteCode ServiceCharacteristic = new InvoiceNoteCode { Value = "AUY" };

    /// <summary>
    /// Comment about an event that is planned.
    /// </summary>
    public static readonly InvoiceNoteCode PlannedEventComment = new InvoiceNoteCode { Value = "AUZ" };

    /// <summary>
    /// Comment about the expected delay.
    /// </summary>
    public static readonly InvoiceNoteCode ExpectedDelayComment = new InvoiceNoteCode { Value = "AVA" };

    /// <summary>
    /// Comment about the requirements for transport.
    /// </summary>
    public static readonly InvoiceNoteCode TransportRequirementsComment = new InvoiceNoteCode { Value = "AVB" };

    /// <summary>
    /// The condition under which the approval is considered.
    /// </summary>
    public static readonly InvoiceNoteCode TemporaryApprovalCondition = new InvoiceNoteCode { Value = "AVC" };

    /// <summary>
    /// Information provided in this category will be used by the trader to make certain declarations in relation to Customs Valuation.
    /// </summary>
    public static readonly InvoiceNoteCode CustomsValuationInformation = new InvoiceNoteCode { Value = "AVD" };

    /// <summary>
    /// Description of the VAT margin scheme applied.
    /// </summary>
    public static readonly InvoiceNoteCode ValueAddedTaxVATMarginScheme = new InvoiceNoteCode { Value = "AVE" };

    /// <summary>
    /// Information about Maritime Declaration of Health.
    /// </summary>
    public static readonly InvoiceNoteCode MaritimeDeclarationOfHealthAVF = new InvoiceNoteCode { Value = "AVF" };

    /// <summary>
    /// Information related to baggage tendered by a passenger, such as odd size indication, tag.
    /// </summary>
    public static readonly InvoiceNoteCode PassengerBaggageInformation = new InvoiceNoteCode { Value = "BAG" };

    /// <summary>
    /// Information about Maritime Declaration of Health.
    /// </summary>
    public static readonly InvoiceNoteCode MaritimeDeclarationOfHealthBAH = new InvoiceNoteCode { Value = "BAH" };

    /// <summary>
    /// Address at which additional information on the product can be found.
    /// </summary>
    public static readonly InvoiceNoteCode AdditionalProductInformationAddress = new InvoiceNoteCode { Value = "BAI" };

    /// <summary>
    /// Specification of free text information which is to be printed on a despatch advice.
    /// </summary>
    public static readonly InvoiceNoteCode InformationToBePrintedOnDespatchAdvice = new InvoiceNoteCode { Value = "BAJ" };

    /// <summary>
    /// Remarks concerning missing goods.
    /// </summary>
    public static readonly InvoiceNoteCode MissingGoodsRemarks = new InvoiceNoteCode { Value = "BAK" };

    /// <summary>
    /// Information related to the non-acceptance of an order, goods or a consignment.
    /// </summary>
    public static readonly InvoiceNoteCode NonAcceptanceInformation = new InvoiceNoteCode { Value = "BAL" };

    /// <summary>
    /// Information related to the return of items.
    /// </summary>
    public static readonly InvoiceNoteCode ReturnsInformation = new InvoiceNoteCode { Value = "BAM" };

    /// <summary>
    /// Note contains information related to sub-line item data.
    /// </summary>
    public static readonly InvoiceNoteCode SubLineItemInformation = new InvoiceNoteCode { Value = "BAN" };

    /// <summary>
    /// Information related to a test.
    /// </summary>
    public static readonly InvoiceNoteCode TestInformation = new InvoiceNoteCode { Value = "BAO" };

    /// <summary>
    /// The external link to a digital document (e.g.: URL).
    /// </summary>
    public static readonly InvoiceNoteCode ExternalLink = new InvoiceNoteCode { Value = "BAP" };

    /// <summary>
    /// Reason for Value Added Tax (VAT) exemption.
    /// </summary>
    public static readonly InvoiceNoteCode VATExemptionReason = new InvoiceNoteCode { Value = "BAQ" };

    /// <summary>
    /// [4180] Clause on a transport document regarding the cargo being consigned. Synonym: Bill of Lading clause.
    /// </summary>
    public static readonly InvoiceNoteCode TransportContractDocumentClause = new InvoiceNoteCode { Value = "BLC" };

    /// <summary>
    /// Instruction with the purpose of preparing the patient.
    /// </summary>
    public static readonly InvoiceNoteCode InstructionToPrepareThePatient = new InvoiceNoteCode { Value = "BLD" };

    /// <summary>
    /// Comment about treatment with medicine.
    /// </summary>
    public static readonly InvoiceNoteCode MedicineTreatmentComment = new InvoiceNoteCode { Value = "BLE" };

    /// <summary>
    /// Comment about the result of an examination.
    /// </summary>
    public static readonly InvoiceNoteCode ExaminationResultComment = new InvoiceNoteCode { Value = "BLF" };

    /// <summary>
    /// Comment about the requested service.
    /// </summary>
    public static readonly InvoiceNoteCode ServiceRequestComment = new InvoiceNoteCode { Value = "BLG" };

    /// <summary>
    /// Details of the reason for a prescription.
    /// </summary>
    public static readonly InvoiceNoteCode PrescriptionReason = new InvoiceNoteCode { Value = "BLH" };

    /// <summary>
    /// Comment concerning a specified prescription.
    /// </summary>
    public static readonly InvoiceNoteCode PrescriptionComment = new InvoiceNoteCode { Value = "BLI" };

    /// <summary>
    /// Comment concerning a clinical investigation.
    /// </summary>
    public static readonly InvoiceNoteCode ClinicalInvestigationComment = new InvoiceNoteCode { Value = "BLJ" };

    /// <summary>
    /// Comment concerning the specification of a medicinal product.
    /// </summary>
    public static readonly InvoiceNoteCode MedicinalSpecificationComment = new InvoiceNoteCode { Value = "BLK" };

    /// <summary>
    /// Comment concerning economic contribution.
    /// </summary>
    public static readonly InvoiceNoteCode EconomicContributionComment = new InvoiceNoteCode { Value = "BLL" };

    /// <summary>
    /// Comment about the status of a plan.
    /// </summary>
    public static readonly InvoiceNoteCode StatusOfAPlan = new InvoiceNoteCode { Value = "BLM" };

    /// <summary>
    /// Information regarding a random sample test.
    /// </summary>
    public static readonly InvoiceNoteCode RandomSampleTestInformation = new InvoiceNoteCode { Value = "BLN" };

    /// <summary>
    /// Text subject is a period of time.
    /// </summary>
    public static readonly InvoiceNoteCode PeriodOfTime = new InvoiceNoteCode { Value = "BLO" };

    /// <summary>
    /// Information about legislation.
    /// </summary>
    public static readonly InvoiceNoteCode Legislation = new InvoiceNoteCode { Value = "BLP" };

    /// <summary>
    /// Text describing security measures that are requested to be executed (e.g. access controls, supervision of ship's stores).
    /// </summary>
    public static readonly InvoiceNoteCode SecurityMeasuresRequested = new InvoiceNoteCode { Value = "BLQ" };

    /// <summary>
    /// [4244] Remarks concerning the complete consignment to be printed on the transport document. Synonym: Bill of Lading remark.
    /// </summary>
    public static readonly InvoiceNoteCode TransportContractDocumentRemark = new InvoiceNoteCode { Value = "BLR" };

    /// <summary>
    /// Text describing the security information as applicable at the port facility in the previous port where a ship/port interface was conducted.
    /// </summary>
    public static readonly InvoiceNoteCode PreviousPortOfCallSecurityInformation = new InvoiceNoteCode { Value = "BLS" };

    /// <summary>
    /// Text describing security related information (e.g security measures currently in force on a vessel).
    /// </summary>
    public static readonly InvoiceNoteCode SecurityInformation = new InvoiceNoteCode { Value = "BLT" };

    /// <summary>
    /// Text describing waste related information.
    /// </summary>
    public static readonly InvoiceNoteCode WasteInformation = new InvoiceNoteCode { Value = "BLU" };

    /// <summary>
    /// Consumer marketing information, short description.
    /// </summary>
    public static readonly InvoiceNoteCode B2CMarketingInformationShortDescription = new InvoiceNoteCode { Value = "BLV" };

    /// <summary>
    /// Trading partner marketing information, long description.
    /// </summary>
    public static readonly InvoiceNoteCode B2BMarketingInformationLongDescription = new InvoiceNoteCode { Value = "BLW" };

    /// <summary>
    /// Consumer marketing information, long description.
    /// </summary>
    public static readonly InvoiceNoteCode B2CMarketingInformationLongDescription = new InvoiceNoteCode { Value = "BLX" };

    /// <summary>
    /// Information on the ingredient make up of the product.
    /// </summary>
    public static readonly InvoiceNoteCode ProductIngredients = new InvoiceNoteCode { Value = "BLY" };

    /// <summary>
    /// Short name of a location e.g. for display or printing purposes.
    /// </summary>
    public static readonly InvoiceNoteCode LocationShortName = new InvoiceNoteCode { Value = "BLZ" };

    /// <summary>
    /// The text contains a description of the material used for packaging.
    /// </summary>
    public static readonly InvoiceNoteCode PackagingMaterialInformation = new InvoiceNoteCode { Value = "BMA" };

    /// <summary>
    /// Text contains information on the material used for stuffing.
    /// </summary>
    public static readonly InvoiceNoteCode FillerMaterialInformation = new InvoiceNoteCode { Value = "BMB" };

    /// <summary>
    /// Text contains information on ship-to-ship activities.
    /// </summary>
    public static readonly InvoiceNoteCode ShipToShipActivityInformation = new InvoiceNoteCode { Value = "BMC" };

    /// <summary>
    /// A description of the type of material for packaging beyond the level covered by standards such as UN Recommendation 21.
    /// </summary>
    public static readonly InvoiceNoteCode PackageMaterialDescription = new InvoiceNoteCode { Value = "BMD" };

    /// <summary>
    /// Textual representation of the markings on a consumer level package.
    /// </summary>
    public static readonly InvoiceNoteCode ConsumerLevelPackageMarking = new InvoiceNoteCode { Value = "BME" };

    /// <summary>
    /// Any coded or clear instruction agreed by customer and carrier regarding the declaration of the goods.
    /// </summary>
    public static readonly InvoiceNoteCode CustomsClearanceInstructions = new InvoiceNoteCode { Value = "CCI" };

    /// <summary>
    /// Any coded or clear instruction agreed by customer and carrier regarding the export declaration of the goods.
    /// </summary>
    public static readonly InvoiceNoteCode CustomsClearanceInstructionsExport = new InvoiceNoteCode { Value = "CEX" };

    /// <summary>
    /// Note contains change information.
    /// </summary>
    public static readonly InvoiceNoteCode ChangeInformation = new InvoiceNoteCode { Value = "CHG" };

    /// <summary>
    /// Any coded or clear instruction agreed by customer and carrier regarding the import declaration of the goods.
    /// </summary>
    public static readonly InvoiceNoteCode CustomsClearanceInstructionImport = new InvoiceNoteCode { Value = "CIP" };

    /// <summary>
    /// Name of the place where Customs clearance is asked to be executed as requested by the consignee/consignor.
    /// </summary>
    public static readonly InvoiceNoteCode ClearancePlaceRequested = new InvoiceNoteCode { Value = "CLP" };

    /// <summary>
    /// Instructions concerning the loading of the container.
    /// </summary>
    public static readonly InvoiceNoteCode LoadingRemarks = new InvoiceNoteCode { Value = "CLR" };

    /// <summary>
    /// Additional information related to an order.
    /// </summary>
    public static readonly InvoiceNoteCode OrderInformation = new InvoiceNoteCode { Value = "COI" };

    /// <summary>
    /// Remarks from or for a supplier of goods or services.
    /// </summary>
    public static readonly InvoiceNoteCode CustomerRemarks = new InvoiceNoteCode { Value = "CUR" };

    /// <summary>
    /// (4034) Note contains customs declaration information.
    /// </summary>
    public static readonly InvoiceNoteCode CustomsDeclarationInformation = new InvoiceNoteCode { Value = "CUS" };

    /// <summary>
    /// Remarks concerning damage on the cargo.
    /// </summary>
    public static readonly InvoiceNoteCode DamageRemarks = new InvoiceNoteCode { Value = "DAR" };

    /// <summary>
    /// [4020] Text of a declaration made by the issuer of a document.
    /// </summary>
    public static readonly InvoiceNoteCode DocumentIssuerDeclaration = new InvoiceNoteCode { Value = "DCL" };

    /// <summary>
    /// Information about delivery.
    /// </summary>
    public static readonly InvoiceNoteCode DeliveryInformation = new InvoiceNoteCode { Value = "DEL" };

    /// <summary>
    /// [4492] Instructions regarding the delivery of the cargo.
    /// </summary>
    public static readonly InvoiceNoteCode DeliveryInstructions = new InvoiceNoteCode { Value = "DIN" };

    /// <summary>
    /// Instructions pertaining to the documentation.
    /// </summary>
    public static readonly InvoiceNoteCode DocumentationInstructions = new InvoiceNoteCode { Value = "DOC" };

    /// <summary>
    /// The text contains a statement constituting a duty declaration.
    /// </summary>
    public static readonly InvoiceNoteCode DutyDeclaration = new InvoiceNoteCode { Value = "DUT" };

    /// <summary>
    /// Physical route effectively used for the movement of the means of transport.
    /// </summary>
    public static readonly InvoiceNoteCode EffectiveUsedRouting = new InvoiceNoteCode { Value = "EUR" };

    /// <summary>
    /// The first block of text to be printed on the transport contract.
    /// </summary>
    public static readonly InvoiceNoteCode FirstBlockToBePrintedOnTheTransportContract = new InvoiceNoteCode { Value = "FBC" };

    /// <summary>
    /// Free text information on a transport document to indicate payment information by Government Bill of Lading.
    /// </summary>
    public static readonly InvoiceNoteCode GovernmentBillOfLadingInformation = new InvoiceNoteCode { Value = "GBL" };

    /// <summary>
    /// Note is general in nature, applies to entire transaction segment.
    /// </summary>
    public static readonly InvoiceNoteCode EntireTransactionSet = new InvoiceNoteCode { Value = "GEN" };

    /// <summary>
    /// Special permission for road transport of certain goods in the German dangerous goods regulation for road transport.
    /// </summary>
    public static readonly InvoiceNoteCode FurtherInformationConcerningGGVSPar7 = new InvoiceNoteCode { Value = "GS7" };

    /// <summary>
    /// [4078] Free form description of a set of handling instructions. For example how specified goods, packages or transport equipment (container) should be handled.
    /// </summary>
    public static readonly InvoiceNoteCode ConsignmentHandlingInstruction = new InvoiceNoteCode { Value = "HAN" };

    /// <summary>
    /// Information pertaining to a hazard.
    /// </summary>
    public static readonly InvoiceNoteCode HazardInformation = new InvoiceNoteCode { Value = "HAZ" };

    /// <summary>
    /// [4070] Any remarks given for the information of the consignee.
    /// </summary>
    public static readonly InvoiceNoteCode ConsignmentInformationForConsignee = new InvoiceNoteCode { Value = "ICN" };

    /// <summary>
    /// (4112) Instructions regarding the cargo insurance.
    /// </summary>
    public static readonly InvoiceNoteCode InsuranceInstructions = new InvoiceNoteCode { Value = "IIN" };

    /// <summary>
    /// Instructions as to which freight and charges components have to be mailed to whom.
    /// </summary>
    public static readonly InvoiceNoteCode InvoiceMailingInstructions = new InvoiceNoteCode { Value = "IMI" };

    /// <summary>
    /// Free text describing goods on a commercial invoice line.
    /// </summary>
    public static readonly InvoiceNoteCode CommercialInvoiceItemDescription = new InvoiceNoteCode { Value = "IND" };

    /// <summary>
    /// Specific note contains insurance information.
    /// </summary>
    public static readonly InvoiceNoteCode InsuranceInformation = new InvoiceNoteCode { Value = "INS" };

    /// <summary>
    /// Note contains invoice instructions.
    /// </summary>
    public static readonly InvoiceNoteCode InvoiceInstruction = new InvoiceNoteCode { Value = "INV" };

    /// <summary>
    /// Data entered by railway stations when required, e.g. specified trains, additional sheets for freight calculations, special measures, etc.
    /// </summary>
    public static readonly InvoiceNoteCode InformationForRailwayPurpose = new InvoiceNoteCode { Value = "IRP" };

    /// <summary>
    /// Information concerning the pre-carriage to the port of discharge if by other means than a vessel.
    /// </summary>
    public static readonly InvoiceNoteCode InlandTransportDetails = new InvoiceNoteCode { Value = "ITR" };

    /// <summary>
    /// Instructions regarding the testing that is required to be carried out on the items in the transaction.
    /// </summary>
    public static readonly InvoiceNoteCode TestingInstructions = new InvoiceNoteCode { Value = "ITS" };

    /// <summary>
    /// Alternative name for a location.
    /// </summary>
    public static readonly InvoiceNoteCode LocationAlias = new InvoiceNoteCode { Value = "LAN" };

    /// <summary>
    /// Note contains line item information.
    /// </summary>
    public static readonly InvoiceNoteCode LineItem = new InvoiceNoteCode { Value = "LIN" };

    /// <summary>
    /// [4080] Instructions where specified packages or containers are to be loaded on a means of transport.
    /// </summary>
    public static readonly InvoiceNoteCode LoadingInstruction = new InvoiceNoteCode { Value = "LOI" };

    /// <summary>
    /// Free text accounting information on an IATA Air Waybill to indicate payment information by Miscellaneous charge order.
    /// </summary>
    public static readonly InvoiceNoteCode MiscellaneousChargeOrder = new InvoiceNoteCode { Value = "MCO" };

    /// <summary>
    /// Information about Maritime Declaration of Health.
    /// </summary>
    public static readonly InvoiceNoteCode MaritimeDeclarationOfHealthMDH = new InvoiceNoteCode { Value = "MDH" };

    /// <summary>
    /// Additional information regarding the marks and numbers.
    /// </summary>
    public static readonly InvoiceNoteCode AdditionalMarksNumbersInformation = new InvoiceNoteCode { Value = "MKS" };

    /// <summary>
    /// Free text contains order instructions.
    /// </summary>
    public static readonly InvoiceNoteCode OrderInstruction = new InvoiceNoteCode { Value = "ORI" };

    /// <summary>
    /// General information created by the sender of general or specific value.
    /// </summary>
    public static readonly InvoiceNoteCode OtherServiceInformation = new InvoiceNoteCode { Value = "OSI" };

    /// <summary>
    /// Information regarding the packaging and/or marking of goods.
    /// </summary>
    public static readonly InvoiceNoteCode PackingMarkingInformation = new InvoiceNoteCode { Value = "PAC" };

    /// <summary>
    /// The free text contains payment instructions information relevant to the message.
    /// </summary>
    public static readonly InvoiceNoteCode PaymentInstructionsInformation = new InvoiceNoteCode { Value = "PAI" };

    /// <summary>
    /// Note contains payables information.
    /// </summary>
    public static readonly InvoiceNoteCode PayablesInformation = new InvoiceNoteCode { Value = "PAY" };

    /// <summary>
    /// Note contains packaging information.
    /// </summary>
    public static readonly InvoiceNoteCode PackagingInformation = new InvoiceNoteCode { Value = "PKG" };

    /// <summary>
    /// The text contains packaging terms information.
    /// </summary>
    public static readonly InvoiceNoteCode PackagingTermsInformation = new InvoiceNoteCode { Value = "PKT" };

    /// <summary>
    /// The free text contains payment details.
    /// </summary>
    public static readonly InvoiceNoteCode PaymentDetailRemittanceInformation = new InvoiceNoteCode { Value = "PMD" };

    /// <summary>
    /// (4438) Note contains payments information.
    /// </summary>
    public static readonly InvoiceNoteCode PaymentInformation = new InvoiceNoteCode { Value = "PMT" };

    /// <summary>
    /// The text contains product information.
    /// </summary>
    public static readonly InvoiceNoteCode ProductInformation = new InvoiceNoteCode { Value = "PRD" };

    /// <summary>
    /// Additional information regarding the price formula used for calculating the item price.
    /// </summary>
    public static readonly InvoiceNoteCode PriceCalculationFormula = new InvoiceNoteCode { Value = "PRF" };

    /// <summary>
    /// (4218) Note contains priority information.
    /// </summary>
    public static readonly InvoiceNoteCode PriorityInformation = new InvoiceNoteCode { Value = "PRI" };

    /// <summary>
    /// Note contains purchasing information.
    /// </summary>
    public static readonly InvoiceNoteCode PurchasingInformation = new InvoiceNoteCode { Value = "PUR" };

    /// <summary>
    /// Instructions regarding quarantine, i.e. the period during which an arriving vessel, including its equipment, cargo, crew or passengers, suspected to carry or carrying a contagious disease is detained in strict isolation to prevent the spread of such a disease.
    /// </summary>
    public static readonly InvoiceNoteCode QuarantineInstructions = new InvoiceNoteCode { Value = "QIN" };

    /// <summary>
    /// Specification of the quality/performance expectations or standards to which the items must conform.
    /// </summary>
    public static readonly InvoiceNoteCode QualityDemandsRequirements = new InvoiceNoteCode { Value = "QQD" };

    /// <summary>
    /// Note contains quotation information.
    /// </summary>
    public static readonly InvoiceNoteCode QuotationInstructionInformation = new InvoiceNoteCode { Value = "QUT" };

    /// <summary>
    /// Information concerning risks induced by the goods and/or handling instruction.
    /// </summary>
    public static readonly InvoiceNoteCode RiskAndHandlingInformation = new InvoiceNoteCode { Value = "RAH" };

    /// <summary>
    /// The free text contains information for regulatory authority.
    /// </summary>
    public static readonly InvoiceNoteCode RegulatoryInformation = new InvoiceNoteCode { Value = "REG" };

    /// <summary>
    /// Free text information on an IATA Air Waybill to indicate consignment returned because of non delivery.
    /// </summary>
    public static readonly InvoiceNoteCode ReturnToOriginInformation = new InvoiceNoteCode { Value = "RET" };

    /// <summary>
    /// The text contains receivables information.
    /// </summary>
    public static readonly InvoiceNoteCode Receivables = new InvoiceNoteCode { Value = "REV" };

    /// <summary>
    /// [3050] Description of a route to be used for the transport of goods.
    /// </summary>
    public static readonly InvoiceNoteCode ConsignmentRoute = new InvoiceNoteCode { Value = "RQR" };

    /// <summary>
    /// The text contains safety information.
    /// </summary>
    public static readonly InvoiceNoteCode SafetyInformation = new InvoiceNoteCode { Value = "SAF" };

    /// <summary>
    /// [4284] Instructions given and declarations made by the sender to the carrier concerning Customs, insurance, and other formalities.
    /// </summary>
    public static readonly InvoiceNoteCode ConsignmentDocumentaryInstruction = new InvoiceNoteCode { Value = "SIC" };

    /// <summary>
    /// Special instructions like licence no, high value, handle with care, glass.
    /// </summary>
    public static readonly InvoiceNoteCode SpecialInstructions = new InvoiceNoteCode { Value = "SIN" };

    /// <summary>
    /// Shipping line requested to be used for traffic between European continent and U.K. for Ireland.
    /// </summary>
    public static readonly InvoiceNoteCode ShipLineRequested = new InvoiceNoteCode { Value = "SLR" };

    /// <summary>
    /// Statement that a special permission has been obtained for the transport (and/or routing) in general, and reference to such permission.
    /// </summary>
    public static readonly InvoiceNoteCode SpecialPermissionForTransportGenerally = new InvoiceNoteCode { Value = "SPA" };

    /// <summary>
    /// Statement that a special permission has been obtained for the transport (and/or routing) of the goods specified, and reference to such permission.
    /// </summary>
    public static readonly InvoiceNoteCode SpecialPermissionConcerningTheGoodsToBeTransported = new InvoiceNoteCode { Value = "SPG" };

    /// <summary>
    /// Note contains special handling information.
    /// </summary>
    public static readonly InvoiceNoteCode SpecialHandling = new InvoiceNoteCode { Value = "SPH" };

    /// <summary>
    /// Statement that a special permission has been obtained for the packaging, and reference to such permission.
    /// </summary>
    public static readonly InvoiceNoteCode SpecialPermissionConcerningPackage = new InvoiceNoteCode { Value = "SPP" };

    /// <summary>
    /// Statement that a special permission has been obtained for the use of the means transport, and reference to such permission.
    /// </summary>
    public static readonly InvoiceNoteCode SpecialPermissionConcerningTransportMeans = new InvoiceNoteCode { Value = "SPT" };

    /// <summary>
    /// Number(s) of subsidiary risks, induced by the goods, according to the valid classification.
    /// </summary>
    public static readonly InvoiceNoteCode SubsidiaryRiskNumberIATADGR = new InvoiceNoteCode { Value = "SRN" };

    /// <summary>
    /// Request for a special service concerning the transport of the goods.
    /// </summary>
    public static readonly InvoiceNoteCode SpecialServiceRequest = new InvoiceNoteCode { Value = "SSR" };

    /// <summary>
    /// Remarks from or for a supplier of goods or services.
    /// </summary>
    public static readonly InvoiceNoteCode SupplierRemarks = new InvoiceNoteCode { Value = "SUR" };

    /// <summary>
    /// [5430] Free text specification of tariff applied to a consignment.
    /// </summary>
    public static readonly InvoiceNoteCode ConsignmentTariff = new InvoiceNoteCode { Value = "TCA" };

    /// <summary>
    /// [8012] Transport information for commercial purposes (generic term).
    /// </summary>
    public static readonly InvoiceNoteCode ConsignmentTransport = new InvoiceNoteCode { Value = "TDT" };

    /// <summary>
    /// General information regarding the transport of the cargo.
    /// </summary>
    public static readonly InvoiceNoteCode TransportationInformation = new InvoiceNoteCode { Value = "TRA" };

    /// <summary>
    /// Stipulation of the tariffs to be applied showing, where applicable, special agreement numbers or references.
    /// </summary>
    public static readonly InvoiceNoteCode RequestedTariff = new InvoiceNoteCode { Value = "TRR" };

    /// <summary>
    /// The text contains a statement constituting a tax declaration.
    /// </summary>
    public static readonly InvoiceNoteCode TaxDeclaration = new InvoiceNoteCode { Value = "TXD" };

    /// <summary>
    /// Note contains warehouse information.
    /// </summary>
    public static readonly InvoiceNoteCode WarehouseInstructionInformation = new InvoiceNoteCode { Value = "WHI" };

    /// <summary>
    /// Note contains information mutually defined by trading partners.
    /// </summary>
    public static readonly InvoiceNoteCode MutuallyDefined = new InvoiceNoteCode { Value = "ZZZ" };

    /// <summary>
    /// [4276] The free form description of the conditions of payment between the parties to a transaction.
    /// </summary>
    public static readonly InvoiceNoteCode TermsOfPayment = new InvoiceNoteCode { Value = "AAB" };
}
